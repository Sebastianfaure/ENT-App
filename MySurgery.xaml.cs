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
    public partial class MySurgery : ContentPage
    {
        public MySurgery()
        {
            InitializeComponent();
        }
        //private async void NavigateButton_OnClicked(object sender, EventArgs e)
        //{
            // await Navigation.PushAsync(new MainPage());
        //}

        //async void MeettheTeamButtonClickedAsync(object sender, EventArgs e)
        //{
            /*  private async void NavigateButton_OnClicked(object sender, EventArgs e) {  
            await Navigation.PushAsync(new SecondPage());  
        }  */
            //   (sender as Button).Text = "Click me again!";
            // await Navigation.PushAsync(new HomePage());
        //}

        private async void TotalLaryngectomy_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Laryngectomy());
        }

        private async void FeedingTube_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ComingSoon());
        }

        private async void NeckDissection_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ComingSoon());
        }

        private async void Tracheostomy_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ComingSoon());
        }

        private async void TORS_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ComingSoon());
        }

        private async void Maxillectom_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ComingSoon());
        }

        private async void MandibleResection_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ComingSoon());
        }

        private async void FreeFlapReconstruction_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ComingSoon());
        }
    }
}
