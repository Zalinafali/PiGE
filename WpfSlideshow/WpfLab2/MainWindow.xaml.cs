using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Media.Imaging;

namespace WpfLab2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            foreach (string path in Directory.GetLogicalDrives())
            {
                myTreeItem folder = new myTreeItem(path);
                folder.Header = path;
                folder.Tag = path;
                folder.Items.Add(emptyItem);
                folder.Expanded += new RoutedEventHandler(folderExpanded);
                treeMenu.Items.Add(folder);
            }
        }

        private object emptyItem = null;

        void folderExpanded(object sender, RoutedEventArgs e)
        {
            myTreeItem folder = (myTreeItem)sender;
            if (folder.Items.Count == 1 && folder.Items[0] == emptyItem)
            {
                folder.Items.Clear();
                try
                {
                    foreach (string path in Directory.GetDirectories(folder.Tag.ToString()))
                    {
                        myTreeItem subFolder = new myTreeItem(path);
                        subFolder.Header = path.Substring(path.LastIndexOf("\\") + 1);
                        subFolder.Tag = path;
                        subFolder.Items.Add(emptyItem);
                        subFolder.Expanded += new RoutedEventHandler(folderExpanded);
                        folder.Items.Add(subFolder);
                    }
                }
                catch (Exception) { }
            }
        }

        private void MenuItem_Click_Open(object sender, RoutedEventArgs e)
        {
            List<ImageInfo> slides = new List<ImageInfo>();

            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "Open Folder";
            DialogResult result = dialog.ShowDialog();

            if (result == System.Windows.Forms.DialogResult.OK)
            {
                string path = dialog.SelectedPath;
                DirectoryInfo folder = new DirectoryInfo(path);
                if (folder.Exists)
                {
                    foreach (FileInfo file in folder.GetFiles())
                    {
                        if (file.Extension == ".PNG" || file.Extension == ".JPG" || file.Extension == ".jpg" || file.Extension == ".png")
                        {
                            BitmapImage bmImage = new BitmapImage(new Uri(file.FullName));
                            slides.Add(new ImageInfo(file.Name, bmImage.Width, bmImage.Height, file.Length));
                        }
                    }
                }
                foreach (ImageInfo img in slides)
                {
                    img.FullPath = path + "\\" + img.Name;
                }
            }
            if (slides.Any())
                areImagesLoaded = true;
            else
                areImagesLoaded = false;
            this.DataContext = slides;
        }

        private void MenuItem_Click_Exit(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        private void MenuItem_Click_About(object sender, RoutedEventArgs e)
        {
            System.Windows.MessageBox.Show("This is simple image application slideshow", "About", MessageBoxButton.OK, MessageBoxImage.Information);
        }


        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (-1 == sourceListView.SelectedIndex)
            {
                MyDataSource.Instance.IsSelected = false;
            }
            else
            {
                MyDataSource.Instance.IsSelected = true;
                fileinfoExpander.DataContext = sourceListView.SelectedItem;
            }
        }

        private bool areImagesLoaded = false;

        // 0 = opacity, 1 = horizontal, 2 = vertical
        private void StartSlideshow(int effect)
        {
            if(areImagesLoaded) {
                SlideshowWindow slideshow = new SlideshowWindow(effect);
                slideshow.ShowDialog();
            }
            else {
                System.Windows.MessageBox.Show("The selected folder does not contain any image to start slideshow!", "An error occured", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
        }

        private void StartSlideshow_Click(object sender, RoutedEventArgs e)
        {
            StartSlideshow(effectComboBox.SelectedIndex);
        }

        private void MenuItem_Click_StartOpacity(object sender, RoutedEventArgs e)
        {
            StartSlideshow(0);
        }

        private void MenuItem_Click_StartHorizontal(object sender, RoutedEventArgs e)
        {
            StartSlideshow(1);
        }

        private void MenuItem_Click_StartVertical(object sender, RoutedEventArgs e)
        {
            StartSlideshow(2);
        }

        private void TreeMenu_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            List<ImageInfo> slides = new List<ImageInfo>();
            string path = ((myTreeItem)e.NewValue).FilePath;
            DirectoryInfo folder = new DirectoryInfo(path);
            if (folder.Exists)
            {
                try
                {
                    foreach (FileInfo file in folder.GetFiles())
                    {
                        if (file.Extension == ".PNG" || file.Extension == ".JPG" || file.Extension == ".jpg" || file.Extension == ".png")
                        {

                            BitmapImage bmImage = new BitmapImage(new Uri(file.FullName));
                            slides.Add(new ImageInfo(file.Name, bmImage.Width, bmImage.Height, file.Length));
                        }
                    }
                }
                catch
                {}
            }
            foreach (ImageInfo image in slides)
            {
                image.FullPath = path + "\\" + image.Name;
            }
            if (slides.Any())
                areImagesLoaded = true;
            else
                areImagesLoaded = false;
            this.DataContext = slides;

        }

    }
}
