using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace EFFUI.CodePages
{
    public class ListPage : ContentPage
    {
        public ListPage()
        {
            var stack = new StackLayout { Orientation = StackOrientation.Vertical };
            var button = new Button { Text = "My List" };
            stack.Children.Add(button);
            Content = stack;
            Title = "LIST";
        }
    }
}
