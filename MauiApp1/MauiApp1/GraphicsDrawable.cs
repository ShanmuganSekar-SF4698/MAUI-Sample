using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace MauiApp1
{
    internal class GraphicsDrawable : IDrawable
    {

        public GraphicsDrawable() 
        {
        }
        public void Draw(ICanvas canvas, RectF dirtyRect)
        {
            Debug.WriteLine($"Height: {dirtyRect.Height}, Width: {dirtyRect.Width}");
        }
    }
}
