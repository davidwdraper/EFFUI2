using System;
using System.Collections.Generic;
using System.Text;
using Telerik.XamarinForms.Input;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace EFFUI.CodePages
{
    public class CalendarPage : BasePage
    {
        public CalendarPage()
        {
            var calendar = new RadCalendar();
            Title = "CALENDAR";

            Content = calendar;
        }
    }
}
