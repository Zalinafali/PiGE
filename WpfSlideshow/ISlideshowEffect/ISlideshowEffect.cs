using static System.Net.Mime.MediaTypeNames;

namespace ISlideshowEffect
{
    public interface ISlideshowEffect
    {
        string Name { get; }
        void PlaySlideshow(Image imageIn, Image imageOut, double windowWidth, double windowHeight);
    }
}
