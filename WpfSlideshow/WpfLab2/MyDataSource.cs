using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfLab2
{
    class MyDataSource : DependencyObject
    {
        // Singleton pattern (Expose a single shared instance, prevent creating additional instances)
        public static readonly MyDataSource Instance = new MyDataSource();
        private MyDataSource() { }

        // Create a DependencyProperty 'CanSeePhotos'
        public bool IsSelected { get { return (bool)GetValue(IsSelectedProperty); } set { SetValue(IsSelectedProperty, value); } }
        public static readonly DependencyProperty IsSelectedProperty = DependencyProperty.Register("IsSelected", typeof(bool), typeof(MyDataSource), new UIPropertyMetadata());
    }
}
