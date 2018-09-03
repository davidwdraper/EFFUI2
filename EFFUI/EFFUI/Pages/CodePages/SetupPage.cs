using EFFUI.CodePages.CRUDPages;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace EFFUI.CodePages
{
    public class SetupPage : BasePage
    {
        public SetupPage()
        {
            var stack = new StackLayout { Orientation = StackOrientation.Vertical, Spacing = 10 };

            Button yourStuff = new Button { Text = "Configure Your Stuff" };
            yourStuff.Clicked += btnYourStuffClicked;
            stack.Children.Add(yourStuff);

            Button addBusiness = new Button { Text = "Manage Businesses" };
            addBusiness.Clicked += btnAddBusiness;
            stack.Children.Add(addBusiness);

            stack.Children.Add(new Button { Text = "Manage Venues" });
            stack.Children.Add(new Button { Text = "Manage Acts" });
            stack.Children.Add(new Button { Text = "Manage Events" });
            stack.Children.Add(new Button { Text = "Manage Entertainers" });

            Content = stack;
            Title = "STUFF";
        }

        private void btnYourStuffClicked(object sender, EventArgs e)
        {
            //Navigation.PushAsync(ProfileCrudPage);
        }

        private void btnAddBusiness(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new BusinessModal());
        }
    }
}
