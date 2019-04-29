using System.Windows.Controls;


namespace WpfLab2
{
    class myTreeItem : TreeViewItem
    {
        public string FilePath;

        public myTreeItem(string fp) : base()
        {
            FilePath = fp;
        }
    }
}
