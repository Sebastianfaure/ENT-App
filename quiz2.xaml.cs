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
    public partial class quiz2 : ContentPage
    {
        public quiz2()
        {
            InitializeComponent();
            webView.Source = "https://docs.google.com/forms/d/e/1FAIpQLScLHQ3bJudy05dVGHBf8LKyZRpxT0m4rwyzI1o5krDoS42Ogg/viewform";
        }
    }
}
