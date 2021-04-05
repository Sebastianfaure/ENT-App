using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ENT_APP
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        async void OnButtonClicked(object sender, EventArgs args)
        {
            //await MeettheTeamButton.RelRotateTo(360, 1000);
        }

        private async void MeettheTeamButton_Clicked(object sender, EventArgs e)
        {

        }

        private async void MySurgery_ClickedAsync(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MySurgery());
        }
    }
}
