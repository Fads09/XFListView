using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XF1ListView
{
    class XFListViewPage1:ContentPage
    {
          public XFListViewPage1()
          {
            var classNames = new[]{
                "Building Cross Platforms Apps with Xamarin Part 1",
                "Building Cross Platforms Apps with Xamarin Part 2",
                "Building Google Glass Apps with c# and Xamarin",
                "Android for .NET Developers"
          };

            Padding = new Thickness(0, Device.OnPlatform(20, 0, 0), 0, 0);

            var listView = new ListView();
            listView.ItemsSource = from c in classNames
                    where c.StartsWith("Building", StringComparison.Ordinal)
                                   select c;

            listView.ItemSelected += (sender, e) =>
            {
                if(e.SelectedItem != null)
                {
                    Debug.WriteLine("Selected: " + e.SelectedItem);

                    listView.SelectedItem = null;
                }

            };

            Content = listView;
        }
    }
}
