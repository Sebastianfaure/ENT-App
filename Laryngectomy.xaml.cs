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

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var expandableDescription = e.Item as ExpandableDescription;
            var xx = BindingContext as MainViewDescription;
            xx?.ShowHideDescription(expandableDescription);
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

public class ExpandableDescription
{
    public string title { get; set; }
    public string description { get; set; }
    public string downURL { get; set; }
    public string upURL { get; set; }
}
