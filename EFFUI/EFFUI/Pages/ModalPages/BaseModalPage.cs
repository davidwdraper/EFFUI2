using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace EFFUI.CodePages
{
    public class BaseModalPage : ContentPage
    {
        /// <summary>
        /// The purpose of this page is to place an Action button at the top
        ///  for pages that do searches and for pages that do CRUD operations.
        /// It also contains a center title lable, and a right status label.
        /// </summary>
        /// 
        public Button ActionButton { get; set; }
        public Label PageTitle { get; set; }
        public Label PageInfo { get; set; }
        public ContentView ContentArea { get; set; }

        public BaseModalPage()
        {
            // We build the BasePage to be a 2 row grid
            // 1st row is the header, the 2nd row is the view
            var outerGrid = new Grid { Margin = new Thickness(0, 30, 0, 0) };

            var row1 = new RowDefinition { Height = new GridLength(40, GridUnitType.Absolute) };
            var row2 = new RowDefinition { Height = new GridLength(1, GridUnitType.Auto) };

            var col1 = new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) };
            var col2 = new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) };
            var col3 = new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) };

            outerGrid.RowDefinitions.Add(row1);
            outerGrid.RowDefinitions.Add(row2);

            outerGrid.ColumnDefinitions.Add(col1);
            outerGrid.ColumnDefinitions.Add(col2);
            outerGrid.ColumnDefinitions.Add(col3);

            ActionButton = new Button { Text = "{{Add Btn Text}}", BackgroundColor = Color.AliceBlue };
            PageTitle = new Label { Text = "{{Add Title}}", BackgroundColor = Color.Azure, VerticalOptions = LayoutOptions.CenterAndExpand, HorizontalOptions = LayoutOptions.CenterAndExpand };
            PageInfo = new Label { Text = "{{Status}}", BackgroundColor = Color.Brown, VerticalOptions = LayoutOptions.CenterAndExpand, HorizontalOptions = LayoutOptions.CenterAndExpand };
            ContentArea = new ContentView { BackgroundColor = Color.Chartreuse, VerticalOptions = LayoutOptions.FillAndExpand };

            outerGrid.Children.Add(ActionButton, 0, 0);
            outerGrid.Children.Add(PageTitle, 1, 0);
            outerGrid.Children.Add(PageInfo, 2, 0);
            outerGrid.Children.Add(ContentArea, 0, 3, 1, 2);

            Content = outerGrid;
        }
    }
}
