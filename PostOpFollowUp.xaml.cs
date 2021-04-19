using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ENT_APP
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PostOpFollowUp : ContentPage
    {
        public PostOpFollowUp()
        {
            InitializeComponent();
        }

        private async void MySurgery_ClickedAsync(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MySurgery());
        }
    }
}
