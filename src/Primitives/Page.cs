using System;
namespace PowerOff.Primitives
{
    public enum PageFormat
    {
        A3,
        A4
    }

    public class Page
    {
        public int Width { get; private set; }
        public int Height { get; private set; }

        private Page(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public static Page Create(PageFormat format)
        {
            switch (format)
            {
                case PageFormat.A3:
                    return new Page(297, 420);
                case PageFormat.A4:
                    return new Page(210, 297);
                default:
                    throw new Exception();
            }
        }

        public void Rotate()
            => (Width, Height) = (Height, Width);
    }
}
