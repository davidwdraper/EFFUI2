using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace EFFUI.CodePages
{
    public class CalendarPage : ContentPage
    {
        public CalendarPage()
        {
            var stack = new StackLayout { Orientation = StackOrientation.Vertical };
            var button = new Button { Text = "Hello Calander" };
            stack.Children.Add(button);
            Content = stack;
            Title = "CALENDAR";
        }
    }
}
