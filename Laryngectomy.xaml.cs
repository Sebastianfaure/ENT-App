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
    public partial class Laryngectomy : ContentPage
    {
        public Laryngectomy()
        {
            InitializeComponent();
        }

        private async void Larynx(object sender, EventArgs e)
        {

        }

        private async void quiz1_ClickedAsync(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new quiz1());
        }

        private async void quiz2_ClickedAsync(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new quiz2());
        }
    }
}
