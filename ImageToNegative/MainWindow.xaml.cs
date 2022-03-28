using Microsoft.Win32;
using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows;
using System.Windows.Media.Imaging;

namespace ImageToNegative
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private BitmapImage originalImg;
        private Bitmap changedInstance;
        private string originalPath;
        private string FileName;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void miExit_Click(object sender, RoutedEventArgs e)
        {
            var main = Application.Current.MainWindow;
            main.Close();
        }

        private void miOpen_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "jpg files (*.jpg)|*.jpg|png files (*.png)|*.jpg|All files (*.*)|*.*|Xoja files (*.xoja)|*.xoja";
            ofd.InitialDirectory = @"D:\wallpaper";

            if (ofd.ShowDialog() == true)
            {
                string imgLocation = ofd.FileName;
                originalPath = ofd.FileName;

                originalImg = new BitmapImage(new Uri(imgLocation));
                txbImgLocation.Text = imgLocation;
                imgOriginal.Source = originalImg;
            }
        }

        private void ImageConvertor(string path, convTypes type)
        {
            if (!string.IsNullOrEmpty(path))
            {
                Bitmap bitmap = new Bitmap(path);
                int height = bitmap.Height;
                int width = bitmap.Width;

                Color p;
                for (int i = 0; i < width; i++)
                {
                    for (int j = 0; j < height; j++)
                    {
                        p = bitmap.GetPixel(i, j);

                        int a = p.A;
                        int r = p.R;
                        int g = p.G;
                        int b = p.B;

                        int new_A = 0;
                        int new_R = 0;
                        int new_G = 0;
                        int new_B = 0;

                        int avg = (r + g + b) / 3;

                        switch (type)
                        {
                            case convTypes.Negative:
                                new_A = a;
                                new_R = 255 - r;
                                new_G = 255 - g;
                                new_B = 255 - b;
                                break;
                            case convTypes.Binary:
                                if (avg > 128)
                                {
                                    new_A = a;
                                    new_R = 255;
                                    new_G = 255;
                                    new_B = 255;
                                }
                                else
                                {
                                    new_A = a;
                                    new_R = 0;
                                    new_G = 0;
                                    new_B = 0;
                                }
                                break;
                            case convTypes.Grayscaled:
                                new_A = a;
                                new_R = avg;
                                new_G = avg;
                                new_B = avg;
                                break;
                            case convTypes.Red:
                                new_R = r;
                                new_G = 0;
                                new_B = 0;
                                break;
                            case convTypes.Green:
                                new_R = 0;
                                new_G = g;
                                new_B = 0;
                                break;
                            case convTypes.Blue:
                                new_R = 0;
                                new_G = 0;
                                new_B = b;
                                break;
                        }

                        bitmap.SetPixel(i, j, Color.FromArgb(a, new_R, new_G, new_B));
                    }
                }
                changedInstance = bitmap;
                using (MemoryStream memory = new MemoryStream())
                {
                    bitmap.Save(memory, ImageFormat.Png);
                    memory.Position = 0;
                    BitmapImage bitmapImage = new BitmapImage();
                    bitmapImage.BeginInit();
                    bitmapImage.StreamSource = memory;
                    bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
                    bitmapImage.EndInit();

                    imgOriginal.Source = bitmapImage;
                }
            }
            else
            {
                MessageBox.Show("Please choose image first", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        #region Converting types
        private void miNegative_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ImageConvertor(originalPath, convTypes.Negative);

            }
            catch (Exception exep)
            {
                var message = exep.Message;
            }
        }

        private void miGrayscaled_Click(object sender, RoutedEventArgs e)
        {
            ImageConvertor(originalPath, convTypes.Grayscaled);
        }

        private void miBinary_Click(object sender, RoutedEventArgs e)
        {
            ImageConvertor(originalPath, convTypes.Binary);
        }

        private void miRed_Click(object sender, RoutedEventArgs e)
        {
            ImageConvertor(originalPath, convTypes.Red);
        }

        private void miGreen_Click(object sender, RoutedEventArgs e)
        {
            ImageConvertor(originalPath, convTypes.Green);
        }

        private void miBlue_Click(object sender, RoutedEventArgs e)
        {
            ImageConvertor(originalPath, convTypes.Blue);
        }
        #endregion Converting types

        enum convTypes
        {
            Binary,
            Negative,
            Grayscaled,
            Red,
            Green,
            Blue
        }

        private void miSaveAs_Click(object sender, RoutedEventArgs e)
        {
            if (changedInstance == null)
            {
                MessageBox.Show("Please modify image first", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                CommonOpenFileDialog dialog = new CommonOpenFileDialog();
                dialog.InitialDirectory = Directory.GetCurrentDirectory();
                dialog.InitialDirectory = "C:\\Users";
                dialog.IsFolderPicker = true;
                if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
                {
                    changedInstance.Save(dialog.FileName + "\\changedImage.png");
                }
            }
        }
    }
}
