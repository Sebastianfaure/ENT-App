using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ENT_APP
{
    class MainViewDescription
    {
        private ExpandableDescription oldDescription;
        public ObservableCollection<ExpandableDescription> listOfExpandableDescriptions { get; set; }

        public MainViewDescription()
        {
            listOfExpandableDescriptions = new ObservableCollection<ExpandableDescription>()
            {
                new ExpandableDescription
                {
                    title = "What is the larynx?",
                    //downURL="downImage.png",
                    //upURL="upImage.png",
                    IsVisible = false,
                    Descriptions = new ObservableCollection<InnerDescription>
                    {
                        new InnerDescription{description="The larynx (LA-ER-INKS) is the medical name for your voice box. Your larynx is in the front of your neck and sits behind the cartilage known as the “adam’s apple”, on top of your windpipe (trachea), in front of your food pipe (esophagus), and below your throat (pharynx). Your larynx allows you to speak, breathe, and swallow normally. It is made up of different types of tissues including cartilage, muscles, and ligaments. These all work together to allow you to make different sounds, breathe, and protect your airway when swallowing."},
                        new InnerDescription{description="The larynx has 3 different parts: upper, middle, and lower. Your doctor might use these terms or the terms in parenthesis below to describe where your cancer is."},
                        new InnerDescription{description="Upper (supraglottis): Supraglottis refers to the upper area of your larynx above your vocal cords and below your epiglottis. Your epiglottis is attached to the back of your throat and covers your airway while you swallow to prevent food or liquids from entering your lungs."},
                        new InnerDescription{description="Middle (glottis): Glottis refers to the area of your larynx that has your vocal cords. These are the parts of your larynx that open and close when you speak, breathe, and swallow."},
                        new InnerDescription{description="Lower (subglottis): Subglottis refers to the lower area of your larynx below your vocal cords where your larynx connects with your windpipe (trachea). Your trachea connects the larynx to your lungs."}
                    }
                },
                new ExpandableDescription
                {
                    title = "What is a laryngectomy?",
                    //downURL = "downImage.png",
                    //upURL = "upImage.png",
                    IsVisible = false,
                    Descriptions = new ObservableCollection<InnerDescription>
                    {
                        new InnerDescription{description="A laryngectomy (LA-RIN-JEK-TOMY) is a surgery to remove part or all of your larynx because of cancer. The amount of your larynx and surrounding tissues that are removed is dependent on the size and location of your cancer and how deeply it has spread. To reduce the chance of any cancer left behind, your surgeon will take a small layer of normal looking tissue surrounding the cancer as well."},
                        new InnerDescription{description="There are two main kinds of laryngectomies: partial and total."},
                        new InnerDescription{description="Partial laryngectomy describes a surgery where your surgeon removes only part of your larynx for the purpose of cancer treatment. This is usually done with smaller cancers that are confined"}
                    }
                },
                new ExpandableDescription
                {
                    title = "Why do I need a laryngectomy?",
                    //downURL = "downImage.png",
                    //upURL = "upImage.png",
                    IsVisible = false,
                    Descriptions = new ObservableCollection<InnerDescription>
                    {
                        new InnerDescription{description="Coming Soon!"}
                    }

                },
                new ExpandableDescription
                {
                    title = "How is a laryngectomy performed?",
                    //downURL = "downImage.png",
                    //upURL = "upImage.png",
                    IsVisible = false,
                    Descriptions = new ObservableCollection<InnerDescription>
                    {
                        new InnerDescription{description="Coming Soon!"}
                    }
                },
                new ExpandableDescription
                {
                    title = "Emotions after surgery:",
                    //downURL = "downImage.png",
                    //upURL = "upImage.png",
                    IsVisible = false,
                    Descriptions = new ObservableCollection<InnerDescription>
                    {
                        new InnerDescription{description="Coming Soon!"}
                    }
                },
                new ExpandableDescription
                {
                    title = "How can I helpy my recovery?",
                    //downURL = "downImage.png",
                    //upURL = "upImage.png",
                    IsVisible = false,
                    Descriptions = new ObservableCollection<InnerDescription>
                    {
                        new InnerDescription{description="Coming Soon!"}
                    }
                },
                new ExpandableDescription
                {
                    title = "When do I call my doctor?",
                    //downURL = "downImage.png",
                    //upURL = "upImage.png",
                    IsVisible = false,
                    Descriptions = new ObservableCollection<InnerDescription>
                    {
                        new InnerDescription{description="Coming Soon!"}
                    }
                },
                new ExpandableDescription
                {
                    title = "Questions to ask your doctor:",
                    //downURL = "downImage.png",
                    //upURL = "upImage.png",
                    IsVisible = false,
                    Descriptions = new ObservableCollection<InnerDescription>
                    {
                        new InnerDescription{description="Coming Soon!"}
                    }
                }

            };

        }

        public void ShowHideDescription(ExpandableDescription description)
        {
            if (oldDescription == description)
            {
                //hide when clicked twice
                description.IsVisible = !description.IsVisible;
                UpdateDescription(description);
            }
            else
            {
                if (oldDescription != null)
                {
                    // hide previous item
                    oldDescription.IsVisible = false;
                    UpdateDescription(description);
                }
            }

            description.IsVisible = true;
            UpdateDescription(description);
        }

        public void UpdateDescription(ExpandableDescription description)
        {
            var index = listOfExpandableDescriptions.IndexOf(description);
            listOfExpandableDescriptions.Remove(description);
            listOfExpandableDescriptions.Insert(index, description);
        }
    }

    public class ExpandableDescription
    {
        public string title { get; set; }
        public bool IsVisible { get; set; }
        public ObservableCollection<InnerDescription> Descriptions { get; set; }
        //public string downURL { get; set; }
        //public string upURL { get; set; }
    }

    public class InnerDescription
    {
        public string description { get; set; }
    }
}
