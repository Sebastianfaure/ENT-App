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
    public partial class MeetTheTeam : ContentPage
    {
        public IList<Doctor> listOfDoctors { get; set; }
        public MeetTheTeam()
        {
            InitializeComponent();
            listOfDoctors = new List<Doctor>();

            listOfDoctors.Add(new Doctor { 
                DoctorName = "Peter T Dziegielewski, MD", 
                Description = "Associate Professor & Chief, Division Of Head And Neck Oncologic And Micro-vascular Reconstructive Surgery", 
                ImageURL = "PeterTDziegielewski.JPEG" 
            });
            listOfDoctors.Add(new Doctor { 
                DoctorName = "Natalie L Silver, MD", 
                Description = "Assistant Professor", 
                ImageURL = "NatalieLSilver.JPEG"
            });
            listOfDoctors.Add(new Doctor { 
                DoctorName = "Deepa Danan, MD", 
                Description = "Assistant Professor, Head And Neck Oncology And Microvascular Reconstructive Surgery, Medical Director - Shands ENT Clinic", 
                ImageURL = "DeepaDanan.JPEG"
            });
            listOfDoctors.Add(new Doctor { 
                DoctorName = "Brian B Hughley, MD", 
                Description = "Assistant Professor", 
                ImageURL = "BrianBHughley.JPEG"
            });

            BindingContext = this;
        }
    }

    public class Doctor
    {
        public string DoctorName { get; set; }
        public string Description { get; set; }
        public string ImageURL { get; set; }
    }
}
