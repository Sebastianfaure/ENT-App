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
        //async void OnButtonClicked(object sender, EventArgs args)
        //{
            //await MeettheTeamButton.RelRotateTo(360, 1000);
        //}

        private async void MeetTheTeam_ClickedAsync(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MeetTheTeam());
        }

        private async void MySurgery_ClickedAsync(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MySurgery());
        }

        private async void PostOpFollowUp_ClickedAsync(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PostOpFollowUp());
        }

        private async void HeadandNeckCancerInformation_ClickedAsync(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ComingSoon());
        }
    }
}
