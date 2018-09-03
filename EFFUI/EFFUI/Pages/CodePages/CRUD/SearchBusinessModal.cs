using System;
using System.Collections.Generic;
using System.Text;
using Telerik.XamarinForms.Input;
using Xamarin.Forms;

namespace EFFUI.CodePages.ModalPages.BusinessModal
{
    class SearchBusinessPage : BasePage
    {
        static string Instructions
        {
            get
            {
                return "Before adding a Business, please ensure that it does not already pre-exist by searching for it.";
            }
        }

        public SearchBusinessPage()
        {
            var stack = new StackLayout();

            stack.Children.Add(new Image { Source = "" }); // Add a page icon
            stack.Children.Add(new Label { Text = Instructions });
            stack.Children.Add(new RadAutoComplete { ItemsSource = null });

        }
    }
}
