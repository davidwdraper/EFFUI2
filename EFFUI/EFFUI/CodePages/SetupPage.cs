using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace EFFUI.CodePages
{
    public class SetupPage : ContentPage
    {
        public SetupPage()
        {
            var stack = new StackLayout { Orientation = StackOrientation.Vertical };
            var button = new Button { Text = "Setup" };
            stack.Children.Add(button);
            Content = stack;
            Title = "SETUP";
        }
    }
}
