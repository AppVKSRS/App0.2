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
    public partial class PhotoStatisticPage : ContentPage
    {
        string Url;
        string PhotoId;
        public PhotoStatisticPage(string url)
        {
            InitializeComponent();
            Url = url;
            image.Source = new UriImageSource
            {
                CachingEnabled = true,
                CacheValidity = new System.TimeSpan(2, 0, 0, 0),
                Uri = new System.Uri(Url)
            };
            PhotoId = VkParser.PhotoUploadUrl.Where(x => x.Value == url).FirstOrDefault().Key;
            Likes.Text = VkParser.PhotosLikes[PhotoId].ToString();
            try
            {
                Comments.Text = VkParser.PostComments[PhotoId].ToString();
            }
            catch
            {
                Comments.Text = "0";
            }
            Reposts.Text = VkParser.PhotosReposts[PhotoId].ToString();
        }
    }
}