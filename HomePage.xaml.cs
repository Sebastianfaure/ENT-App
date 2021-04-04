using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void OnButtonClicked(object sender, EventArgs args)
        {
            await MeettheTeamButton.RelRotateTo(360, 1000);
        }

        private async void MeettheTeamButton_Clicked(object sender, EventArgs e)
        {
           
        }

        private async void MySurgery_ClickedAsync(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page1());
        }
    }
}

//
/* 
public class CodeButtonClickPage : ContentPage
{
    public CodeButtonClickPage ()
    {
        Title = "Code Button Click";

        Label label = new Label
        {
            Text = "Click the Button below",
            FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
            VerticalOptions = LayoutOptions.CenterAndExpand,
            HorizontalOptions = LayoutOptions.Center
        };

        Button button = new Button
        {
            Text = "Click to Rotate Text!",
            VerticalOptions = LayoutOptions.CenterAndExpand,
            HorizontalOptions = LayoutOptions.Center
        };
        button.Clicked += async (sender, args) => await label.RelRotateTo(360, 1000);

        Content = new StackLayout
        {
            Children =
            {
                label,
                button
            }
        };
    }
}

           Button button = new Button
            {
                Text = "Meet the Team",
                TextColor = Color.Turquoise,
                FontSize = 20,
                // FontAttributes =  Bold,
                BackgroundColor = Color.White,
                BorderColor = Color.Black,
                BorderWidth = 2,
                CornerRadius = 5,
                WidthRequest = 150,
                HeightRequest = 75,
                //  Clicked = "MeettheTeamButtonClicked"

            };
            button.Clicked += ButtonClicked;
            Content = button;

            this.Content = new StackLayout
            {
                Children =
                {
                    button
                }
            };
        }

        private async void ButtonClicked(object sender, EventArgs e)
        {
            // throw new NotImplementedException();

            // await NavigationPage(new MeettheTeamPage());
            // await Navigation.(new MeettheTeamPage());

            throw new System.InvalidOperationException();
        }

        async void MeettheTeamButtonClickedAsync(object sender, EventArgs e)
        {
              private async void NavigateButton_OnClicked(object sender, EventArgs e) {  
            await Navigation.PushAsync(new SecondPage());  
        }  
            //   (sender as Button).Text = "Click me again!";
            await Navigation.PushAsync(new Page1());
        }
    }
} */
