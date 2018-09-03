using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace EFFUI.Pages.Common
{
    class EntitySearch
    {
        public string Name { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string PCode { get; set; }

        public StackLayout BuildSearch()
        {
            var stack = new StackLayout();
            return stack;
        }
    }
}
