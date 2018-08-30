using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace EFFUI.CodePages
{
    public class MapPage : ContentPage
    {
        public MapPage()
        {
            var position = new Position(27.83511, -82.83459);
            var map = new Map(
                MapSpan.FromCenterAndRadius(position, Distance.FromMiles(0.3)))
            {
                IsShowingUser = true,
                HeightRequest = 100,
                WidthRequest = 960,
                VerticalOptions = LayoutOptions.FillAndExpand,
            };

            var pin1 = new Pin { Position = new Position(27.83511, -82.83459), Label = "Sex Here", Type = PinType.Generic };
            map.Pins.Add(pin1);

            var pin2 = new Pin { Position = new Position(27.83521, -82.83459), Label = "Home", Type = PinType.Place };
            map.Pins.Add(pin2);

            var pin3 = new Pin { Position = new Position(27.83531, -82.83459), Label = "Work", Type = PinType.SavedPin };
            map.Pins.Add(pin3);

            var pin4 = new Pin { Position = new Position(27.83541, -82.83459), Label = "Hooters", Type = PinType.SearchResult };
            map.Pins.Add(pin4);

            var stack = new StackLayout { Spacing = 0 };
            stack.Children.Add(map);
            Content = stack;
            Title = "MAP";
        }
    }
}
