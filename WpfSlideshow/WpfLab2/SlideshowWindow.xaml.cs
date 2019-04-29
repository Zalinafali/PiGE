using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Threading;

namespace WpfLab2
{
    /// <summary>
    /// Interaction logic for SlideshowWindow.xaml
    /// </summary>
    public partial class SlideshowWindow : Window
    {
        public SlideshowWindow(int setEffect)
        {
            InitializeComponent();
            effect = setEffect;
            LoadImages();
            StartSlideshow();  
        }

        private Storyboard storyBoardIn;
        private Storyboard storyBoardOut;
        private int effect;

        private DispatcherTimer dtClockTime { get; set; }
        private List<string> imagePaths;
        private int currentIndex;

        private void LoadImages()
        {
            currentIndex = 0;
            imagePaths = new List<string>();
            foreach (ImageInfo i in (List<ImageInfo>)((MainWindow)Application.Current.MainWindow).DataContext)
                imagePaths.Add(i.FullPath);
        }

        private void StartSlideshow()
        {
            dtClockTime = new DispatcherTimer();

            dtClockTime.Interval = new TimeSpan(0, 0, 5); //in Hour, Minutes, Second.
            dtClockTime.Tick += DtClockTime_Tick;

            dtClockTime.Start();

            BitmapSource bs = new BitmapImage(new Uri((string)imagePaths[currentIndex]));
            slide.Source = bs;
        }

        private void DtClockTime_Tick(object sender, EventArgs e)
        {
            int oldIndex = currentIndex;
            currentIndex = ++currentIndex % imagePaths.Count;
            try
            {
                BitmapSource bs = new BitmapImage(new Uri((string)imagePaths[oldIndex]));
                slide.Source = bs;
            }
            catch { }
            try
            {
                BitmapSource bs2 = new BitmapImage(new Uri((string)imagePaths[currentIndex]));
                nextSlide.Source = bs2;
            }
            catch { }
            switch (effect)
            {
                case 0:
                    PlaySlideshowOpacity(nextSlide, slide, 1024, 768);
                    break;
                case 1:
                    PlaySlideshowHorizontal(nextSlide, slide, 1024, 768);
                    break;
                case 2:
                    PlaySlideshowVertical(nextSlide, slide, 1024, 768);
                    break;
                default:
                    break;
            }
        }

        private void ShowRightClickMenu(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ContextMenu cntxMenu = this.FindResource("rightClickMenu") as ContextMenu;
            cntxMenu.PlacementTarget = sender as Button;
            cntxMenu.IsOpen = true;
        }

        private void ShowSlide(string path)
        {
            try
            {
                BitmapSource bs = new BitmapImage(new Uri((string)path));
                slide.Source = bs;
            }
            catch { }
        }

        private void PlayPause(object sender, RoutedEventArgs e)
        {
            if (dtClockTime.IsEnabled)
                dtClockTime.Stop();
            else
                dtClockTime.Start();
        }

        private void CloseWindow(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        // EFFECTS

        public void PlaySlideshowOpacity(Image imageIn, Image imageOut, double windowWidth, double windowHeight)
        {
            storyBoardIn = new Storyboard();
            storyBoardOut = new Storyboard();
            DoubleAnimation animationIn = new DoubleAnimation(0.0, 1.0, new TimeSpan(0, 0, 0, 0, 500));
            Storyboard.SetTargetProperty(animationIn, new PropertyPath(UIElement.OpacityProperty));
            Storyboard.SetTarget(animationIn, imageIn);
            DoubleAnimation animationOut = new DoubleAnimation(1.0, 0.0, new TimeSpan(0, 0, 0, 0, 500));
            Storyboard.SetTargetProperty(animationOut, new PropertyPath(UIElement.OpacityProperty));
            Storyboard.SetTarget(animationOut, imageOut);
            storyBoardIn.Children.Add(animationIn);
            storyBoardOut.Children.Add(animationOut);
            storyBoardIn.Begin();
            storyBoardOut.Begin();
        }

        public void PlaySlideshowHorizontal(Image imageIn, Image imageOut, double windowWidth, double windowHeight)
        {
            imageIn.HorizontalAlignment = HorizontalAlignment.Right;
            imageOut.HorizontalAlignment = HorizontalAlignment.Left;
            storyBoardIn = new Storyboard();
            storyBoardOut = new Storyboard();
            DoubleAnimation animationIn = new DoubleAnimation(0.0, windowWidth, new TimeSpan(0, 0, 0, 0, 500));
            Storyboard.SetTargetProperty(animationIn, new PropertyPath(FrameworkElement.WidthProperty));
            Storyboard.SetTarget(animationIn, imageIn);
            DoubleAnimation animationOut = new DoubleAnimation(windowWidth, 0.0, new TimeSpan(0, 0, 0, 0, 500));
            Storyboard.SetTargetProperty(animationOut, new PropertyPath(FrameworkElement.WidthProperty));
            Storyboard.SetTarget(animationOut, imageOut);
            storyBoardIn.Children.Add(animationIn);
            storyBoardOut.Children.Add(animationOut);
            storyBoardIn.Begin();
            storyBoardOut.Begin();
        }

        public void PlaySlideshowVertical(Image imageIn, Image imageOut, double windowWidth, double WindowHeigh)
        {
            imageIn.VerticalAlignment = VerticalAlignment.Bottom;
            imageOut.VerticalAlignment = VerticalAlignment.Top;
            storyBoardIn = new Storyboard();
            storyBoardOut = new Storyboard();
            DoubleAnimation animationIn = new DoubleAnimation(0.0, WindowHeigh, new TimeSpan(0, 0, 0, 0, 500));
            Storyboard.SetTargetProperty(animationIn, new PropertyPath(FrameworkElement.HeightProperty));
            Storyboard.SetTarget(animationIn, imageIn);
            DoubleAnimation animationOut = new DoubleAnimation(WindowHeigh, 0.0, new TimeSpan(0, 0, 0, 0, 500));
            Storyboard.SetTargetProperty(animationOut, new PropertyPath(FrameworkElement.HeightProperty));
            Storyboard.SetTarget(animationOut, imageOut);
            storyBoardIn.Children.Add(animationIn);
            storyBoardOut.Children.Add(animationOut);
            storyBoardIn.Begin();
            storyBoardOut.Begin();
        }
    }
}
