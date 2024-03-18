namespace Morpher
{
    public partial class Morpher : Form
    {
        private CancellationTokenSource _updateTokenSource = new CancellationTokenSource();
        private PixelMapData[,]? _patternToImageMap = null;
        private PixelMapData[,]? _imageToPatternMap = null;
        private double patternBarHpos = 0.5d;
        private double patternBarVpos = 0.5d;
        private double imageBarHpos = 0.5d;
        private double imageBarVpos = 0.5d;

        public Morpher()
        {
            InitializeComponent();
        }

        private async void patternOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string file = openFileDialog.FileName;
                patternFile.Text = file;
                patternPictureBox.Image = Image.FromFile(file);
                direction.Text = ">";
                _patternToImageMap = null;
                _imageToPatternMap = null;
                await update();
            }
        }

        private void patternSave_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string file = saveFileDialog.FileName;
                patternFile.Text = file;
                patternPictureBox.Image.Save(file);
            }
        }

        private async void imageOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string file = openFileDialog.FileName;
                imageFile.Text = file;
                imagePictureBox.Image = Image.FromFile(file);
                direction.Text = "<";
                _patternToImageMap = null;
                _imageToPatternMap = null;
                await update();
            }
        }

        private void imageSave_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string file = saveFileDialog.FileName;
                imageFile.Text = file;
                imagePictureBox.Image.Save(file);
            }
        }

        private async void direction_Click(object sender, EventArgs e)
        {
            direction.Text = direction.Text == ">" ? "<" : ">";
            await update();
        }

        private async void Morpher_Resize(object sender, EventArgs e)
        {
            _imageToPatternMap = null;
            _patternToImageMap = null;
            await update();
        }

        private async void patternParams_Change(object sender, EventArgs e)
        {
            _imageToPatternMap = null;
            patternBarHpos = (double)patternBarH.Value / patternBarH.Maximum;
            patternBarVpos = (double)patternBarV.Value / patternBarV.Maximum;
            await update();
        }

        private async void imageParams_Change(object sender, EventArgs e)
        {
            _patternToImageMap = null;
            imageBarHpos = (double)imageBarH.Value / imageBarH.Maximum;
            imageBarVpos = (double)imageBarV.Value / imageBarV.Maximum;
            await update();
        }

        private async Task update()
        {
            _updateTokenSource.Cancel();
            if (direction.Text == ">")
            {
                if (patternPictureBox.Image != null)
                {
                    _updateTokenSource = new CancellationTokenSource();
                    await PatternToImage(_updateTokenSource.Token);
                }
            }
            else
            {
                if (imagePictureBox.Image != null)
                {
                    _updateTokenSource = new CancellationTokenSource();
                    await ImageToPattern(_updateTokenSource.Token);
                }
            }
        }

        private async Task PatternToImage(CancellationToken cancellationToken)
        {
            try
            {
                await Task.Run(() =>
                {
                    var watch = System.Diagnostics.Stopwatch.StartNew();

                    Bitmap patternBitmap = new Bitmap(patternPictureBox.Image);
                    int patternWidth = patternBitmap.Width;
                    int patternHeight = patternBitmap.Height;

                    int imageWidth = imagePictureBox.Width;
                    int imageHeight = imagePictureBox.Height;

                    int imageOriginX = (int)(imageWidth * imageBarHpos);
                    int imageOriginY = (int)(imageHeight * (1 - imageBarVpos));

                    int maxDX = (imageWidth - imageOriginX) > (imageOriginX - imageWidth)
                        ? imageWidth - imageOriginX
                        : imageOriginX - imageWidth;
                    int maxDY = (imageHeight - imageOriginY) > (imageOriginY - imageHeight)
                        ? imageHeight - imageOriginY
                        : imageOriginY - imageHeight;
                    double maxLogLength = Math.Log(1 + Math.Sqrt(maxDX * maxDX + maxDY * maxDY));
                    double scaleX = patternWidth / maxLogLength;
                    double scaleY = patternHeight / (Math.PI * 2.0d);

                    if (_patternToImageMap == null)
                    {
                        _patternToImageMap = new PixelMapData[imageWidth, imageHeight];
                        for (int imageY = 0; imageY < imageHeight; imageY++)
                        {
                            cancellationToken.ThrowIfCancellationRequested();
                            for (int imageX = 0; imageX < imageWidth; imageX++)
                            {
                                double dx = imageX - imageOriginX;
                                double dy = imageOriginY - imageY;
                                double logLength = Math.Log(1 + Math.Sqrt(dx * dx + dy * dy));
                                double angle = 0d;
                                if (dx == 0d)
                                {
                                    if (dy < 0d)
                                    {
                                        angle = Math.PI * 1.5d;
                                    }
                                    if (dy > 0d)
                                    {
                                        angle = Math.PI * 0.5d;
                                    }
                                }
                                else
                                {
                                    angle = Math.Atan(dy / dx);
                                    if (dx < 0d) angle += Math.PI;
                                }
                                angle = (angle + Math.PI * 2.0d) % (Math.PI * 2.0d);
                                _patternToImageMap[imageX, imageY] = new PixelMapData
                                {
                                    srcX = logLength * scaleX,
                                    srcY = angle * scaleY
                                };
                            }
                        }
                    }

                    Bitmap imageBitmap = new Bitmap(imageWidth, imageHeight);

                    int patternOriginX = (int)(patternWidth * patternBarHpos);
                    int patternOriginY = (int)(patternHeight * (1 - patternBarVpos));

                    for (int imageY = 0; imageY < imageHeight; imageY++)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        for (int imageX = 0; imageX < imageWidth; imageX++)
                        {
                            PixelMapData imagePt = _patternToImageMap[imageX, imageY];
                            int patternX = (((int)(patternOriginX + imagePt.srcX) % patternWidth) + patternWidth) % patternWidth;
                            int patternY = (((int)(patternOriginY + imagePt.srcY) % patternHeight) + patternHeight) % patternHeight;
                            imageBitmap.SetPixel(imageX, imageY, patternBitmap.GetPixel(patternX, patternY));
                        }
                    }

                    imagePictureBox.Image = imageBitmap;

                    Console.WriteLine("PatternToImage took {0} milliseconds", watch.ElapsedMilliseconds);
                    watch.Stop();
                });
            }
            catch (OperationCanceledException) { }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private async Task ImageToPattern(CancellationToken cancellationToken)
        {
            try
            {
                await Task.Run(() =>
                {
                    var watch = System.Diagnostics.Stopwatch.StartNew();
                    Console.WriteLine("ImageToPattern took {0} milliseconds", watch.ElapsedMilliseconds);
                    watch.Stop();
                });
            }
            catch (OperationCanceledException) { }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
