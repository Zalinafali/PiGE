using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WpfLab2
{
    public class ImageInfo
    {
        public string Name { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public double Size { get; set; }
        public string FullPath { get; set; }

        public ImageInfo(string name, double width, double height, double size)
        {
            Name = name;
            Width = (int)width;
            Height = (int)height;
        }
    }

}
