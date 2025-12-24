using System;
using System.Collections.Generic;
using System.Text;

namespace MauiApp1
{
    internal class ParentView : ContentView
    {
        public ParentView() 
        {
            this.WidthRequest = 100;
            this.HeightRequest = 50;

            this.Content = new CustomGraphicsView();    
        }
    }

    internal class CustomGraphicsView : GraphicsView
    {
        public CustomGraphicsView() 
        {
            Drawable = new GraphicsDrawable();
        }
    }
}
