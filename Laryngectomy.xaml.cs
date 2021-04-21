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
        public IList<ExpandableDescription> listOfExpandableDescriptions { get; set; }
        

        public Laryngectomy()
        {
            InitializeComponent();
            listOfExpandableDescriptions = new List<ExpandableDescription>();

            listOfExpandableDescriptions.Add(new ExpandableDescription
            {
                Title = "What is the larynx?",
                Description = "The larynx (LA-ER-INKS) is the medical name for your voice box. Your larynx is in the front of your neck and sits behind the cartilage known as the adam's apple, on top of your windpipe (trachea), in front of your food pipe (esophagus), and below your throat (pharynx). Your larynx allows you to speak, breathe, and swallow normally. It is made up of different types of tissues including cartilage, muscles, and ligaments. These all work together to allow you to make different sounds, breathe, and protect your airway when swallowing."
            });
            listOfExpandableDescriptions.Add(new ExpandableDescription
            {
                Title = "",
                Description = "",
            });

            BindingContext = this;
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
    public string Title { get; set; }
    public string Description { get; set; }
}
