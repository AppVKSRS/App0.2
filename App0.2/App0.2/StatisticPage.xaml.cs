using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App0._2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StatisticPage : ContentPage
    {
        string url = "https://sun9-34.userapi.com/impf/c853624/v853624041/83de7/4q6hzLRhHIQ.jpg?size=1080x1080&quality=96&sign=3d5bbbf91532c0d6b5dee499430b2caf&type=album";
        public StatisticPage()
        {
            InitializeComponent();
            for (int i = 0; i < 10; i++)
            {
                grid.RowSpacing = 1;
                grid.RowDefinitions.Add(new RowDefinition() { Height = 150});
                for (int j = 0; j < 3; j++)
                {
                    Image image = new Image();
                    image.Source = new UriImageSource
                    {
                        CachingEnabled = true,
                        CacheValidity = new System.TimeSpan(2, 0, 0, 0),
                        Uri = new System.Uri(url)
                    };
                    grid.Children.Add(image, j, i);
                }
            }
        }
    }
}