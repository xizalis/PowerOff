using System;
namespace PowerOff.Primitives
{
    public struct Page
    {
        public int Width { get; private set; }
        public int Height { get; private set; }

        public Page(int width, int height)
        {
            Width = width;
            Height = height;
        }
    }
}
