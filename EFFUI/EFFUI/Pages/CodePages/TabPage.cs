using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace EFFUI.CodePages
{
    public class TabPage : TabbedPage
    {
        public TabPage()
        {
            Children.Add(new MapPage());
            Children.Add(new CalendarPage());
            Children.Add(new ListPage());
            Children.Add(new CheckInPage());
            Children.Add(new SetupPage());
        }
    }
}
