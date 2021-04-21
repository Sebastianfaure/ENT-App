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
                title = "What is the larynx?",
                description = "The larynx (LA-ER-INKS) is the medical name for your voice box. Your larynx is in the front of your neck and sits behind the cartilage known as the adam's apple, on top of your windpipe (trachea), in front of your food pipe (esophagus), and below your throat (pharynx). Your larynx allows you to speak, breathe, and swallow normally. It is made up of different types of tissues including cartilage, muscles, and ligaments. These all work together to allow you to make different sounds, breathe, and protect your airway when swallowing."
            });
            listOfExpandableDescriptions.Add(new ExpandableDescription
            {
                title = "What is a laryngectomy?",
                description = "A laryngectomy (LA-RIN-JEK-TOMY) is a surgery to remove part or all of your larynx because of cancer. The amount of your larynx and surrounding tissues that are removed is dependent on the size and location of your cancer and how deeply it has spread. To reduce the chance of any cancer left behind, your surgeon will take a small layer of normal looking tissue surrounding the cancer as well.  There are two main kinds of laryngectomies: partial and total.  Partial laryngectomy describes a surgery where your surgeon removes only part of your larynx for the purpose of cancer treatment. This is usually done with smaller cancers that are confined to one area of your voice box.  Total laryngectomy describes a surgery where your surgeon removes all of your voice box for the purpose of cancer treatment. Depending on the extent of your tumor, your surgeon may remove part or all of your pharynx (FA-ER-INKS) as well, this is called a laryngopharyngectomy.  Your pharynx is the tube that connects your nose and mouth to your windpipe and esophagus, also known as the throat.",
            });
            listOfExpandableDescriptions.Add(new ExpandableDescription
            {
                title = "Why do i need a laryngectomy?",
                description = "Coming soon",
            });
            listOfExpandableDescriptions.Add(new ExpandableDescription
            {
                title = "How is a laryngectomy performed?",
                description = "Coming soon",
            });
            listOfExpandableDescriptions.Add(new ExpandableDescription
            {
                title = "Emotions after surgery.",
                description = "Coming soon",
            });
            listOfExpandableDescriptions.Add(new ExpandableDescription
            {
                title = "How can I helpy my recovery?",
                description = "Coming soon",
            });
            listOfExpandableDescriptions.Add(new ExpandableDescription
            {
                title = "When to call my doctor",
                description = "Coming soon",
            });
            listOfExpandableDescriptions.Add(new ExpandableDescription
            {
                title = "Questions to ask your doctor:",
                description = "Coming soon",
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
    public string title { get; set; }
    public string description { get; set; }
}
