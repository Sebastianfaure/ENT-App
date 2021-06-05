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
                    Title = "What is the larynx?",
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
                    Title = "What is a laryngectomy?",
                    //downURL = "downImage.png",
                    //upURL = "upImage.png",
                    IsVisible = false,
                    Descriptions = new ObservableCollection<InnerDescription>
                    {
                        new InnerDescription{description="A laryngectomy (LA-RIN-JEK-TOMY) is a surgery to remove part or all of your larynx because of cancer. The amount of your larynx and surrounding tissues that are removed is dependent on the size and location of your cancer and how deeply it has spread. To reduce the chance of any cancer left behind, your surgeon will take a small layer of normal looking tissue surrounding the cancer as well."},
                        new InnerDescription{description="There are two main kinds of laryngectomies: partial and total."},
                        new InnerDescription{description="Partial laryngectomy describes a surgery where your surgeon removes only part of your larynx for the purpose of cancer treatment. This is usually done with smaller cancers that are confined to one area of your voice box."},
                          new InnerDescription{description="Total laryngectomy describes a surgery where your surgeon removes all of your voice box for the purpose of cancer treatment. Depending on the extent of your tumor, your surgeon may remove part or all of your pharynx (FA-ER-INKS) as well, this is called a laryngopharyngectomy.  Your pharynx is the tube that connects your nose and mouth to your windpipe and esophagus, also known as the throat."}
                    }
                },
                new ExpandableDescription
                {
                    Title = "Why do I need a laryngectomy?",
                    //downURL = "downImage.png",
                    //upURL = "upImage.png",
                    IsVisible = false,
                    Descriptions = new ObservableCollection<InnerDescription>
                    {
                        new InnerDescription{description="You may need a laryngectomy if you have cancer that has developed in or around your voice box. When cancer grows, it can invade other structures that surround the original tumor. Cancer in the larynx can spread to your pharynx in this way, and visa versa. If your cancer has developed in your larynx, you will need a surgery to remove the cancer. You may need a laryngectomy for other reasons such as: severe trauma to the larynx such as a gunshot wound, or severe damage to the larynx from previous radiation therapy."},
                         new InnerDescription{description="Your doctor will perform a variety of steps in order to decide if a laryngectomy is indicated in your care. These steps include getting a detailed history of your symptoms, examining your head and neck area, taking images with X-rays, CT (cat) scans, or MRIs, and in some cases, taking a small piece of your larynx to look at under the microscope."}
                    }

                },
                new ExpandableDescription
                {
                    Title = "How is a laryngectomy performed?",
                    //downURL = "downImage.png",
                    //upURL = "upImage.png",
                    IsVisible = false,
                    Descriptions = new ObservableCollection<InnerDescription>
                    {
                        new InnerDescription{description="Laryngectomies are performed in the operating room while you are asleep (under anesthesia). Your surgeon will make a cut in the skin on your neck to allow them to see and access your larynx. Depending on your cancer, your surgeon will then remove part or all of your larynx and/or pharynx. The removed tissue will then be sent to a specialist to look at under the microscope to confirm if the cancer cells were removed. During your surgery, you will also have glands (lymph nodes) in your neck removed. This is called a neck dissection (see neck dissection pamphlet). If part or all of your pharynx is removed, you will have reconstruction as part of your surgery to create a “neopharynx” or new pharynx. This is done using a free flap of muscle or skin from another part of your body to reconnect your mouth to your esophagus. There are many kinds of free flaps and your doctor will decide which is best for your reconstruction (see free flap pamphlets). This reconstruction is done with the goal of allowing you to eat and drink by mouth in the future. Once your larynx is removed, there is no longer a connection between your nose and mouth and your lungs. To allow you to breathe, your surgeon will connect your windpipe (trachea) to a hole made in the front of your neck. This is called a tracheostoma (stoma for short) and will be the new and permanent opening in your airway (see below). During your surgery, your doctor will insert a feeding tube to help you get water, nutrients, and medications until your ability to swallow is assessed (see feeding tube pamphlet)."}
                    }
                },
                new ExpandableDescription
                {
                    Title = "What to expect",
                    //downURL = "downImage.png",
                    //upURL = "upImage.png",
                    IsVisible = false,
                    Descriptions = new ObservableCollection<InnerDescription>
                    {
                        new InnerDescription{description="When you wake up from surgery, you will be moved to your hospital room and monitored closely as you recover."},
                          new InnerDescription{description="It is normal to have some pain after surgery and you will be asked often about your level of pain and given pain medication as needed."},
                            new InnerDescription{description="You will be breathing through a tracheostoma in the front of your neck. A laryngectomy tube will be placed in this stoma which will be suctioned and cleaned by the nurse looking after you. Your nurse will teach you how to suction and clean this tube at home. You will have a collar around your neck that will deliver humidified oxygen through this tube."},
                              new InnerDescription{description="You will have a feeding tube in your nose or in your abdomen that will help you get nutrients, water, and medications until your ability to swallow is assessed. If you have a reconstructed pharynx connecting your mouth and your esophagus, you may have a swallow study to make sure food and water will not leak out when you swallow. If you are having difficulty swallowing, you may need to go home with a feeding tube to make sure your body gets enough nutrients to stay strong during your recovery. You will learn how to feed yourself through your feeding tube during your hospital stay."},
                                new InnerDescription{description="You will not be able to speak normally after surgery. Most people find it helpful to use a pen and paper or portable device to help you communicate until you are able to start exploring alternative speaking methods."},
                                  new InnerDescription{description="If you received reconstruction with a free flap as part of your surgery, you will have a machine called a doppler in place that makes sure the tissue is getting enough blood flow. If, for any reason, the tissue is not getting blood flow, you may need to return to the operating room to get blood flowing again to the area."},
                                    new InnerDescription{description="You will have drains in your neck to help prevent fluid from collecting under your skin. The drains do not hurt and will be emptied regularly. When a drain is filling with less than 30 milliliters in 24 hours, it will be removed. This may happen during your hospital stay or shortly after in the clinic. You may feel some momentary discomfort while the drain is removed. "},
                                      new InnerDescription{description="You may have a urinary catheter in your bladder to allow urine to drain freely. This will likely be removed in the first days after surgery."},
                                        new InnerDescription{description="Stitches, staples, and dressings will be checked regularly and removed or replaced as needed. "}
                       
                    }
                },
                      new ExpandableDescription
                {
                    Title = "What are the risks of a laryngectomy?",
                    //downURL = "downImage.png",
                    //upURL = "upImage.png",
                    IsVisible = false,
                    Descriptions = new ObservableCollection<InnerDescription>
                    {
                        new InnerDescription{description="Your doctor will discuss with you all the risks of your surgery."},
                         new InnerDescription{description="The risks of laryngectomy include the risks that are common to all surgeries such as bleeding, infections, blood clots, adverse reaction to medications used during anesthesia, damage to surrounding structures, and other complications."},
                          new InnerDescription{description="Risks specific to laryngectomy include:"},
                           new InnerDescription{description="Fistula: A fistula is an abnormal opening between your mouth or throat and your skin. This can happen if your wound heals abnormally and puts you at risk for infection. If a fistula develops, you may be able to help it close with medicines like antibiotics that prevent infections and routine wound care. If it does not close or is very large, you may need another surgery to clean the area and fix the opening."},
                            new InnerDescription{description="Neopharynx leak: If the tube used to reconstruct the pharynx does not heal properly, saliva and food can leak out and put you at risk for infection. This may require another surgery to fix the leak."},
                             new InnerDescription{description="Stoma stenosis: This is where your stoma becomes smaller or more narrow. This may require another procedure to open the stoma and allow you to breathe easier."},
                              new InnerDescription{description="Low calcium levels: The amount of calcium in your body is regulated by tiny glands next to your larynx. These glands may be injured or removed during your surgery which can result in you having temporary or permanent low blood calcium. Low blood calcium can give you muscle cramps or a tingly feeling around your mouth or in your fingers. Low blood calcium can be corrected with calcium tablets."},
                               new InnerDescription{description="Low thyroid levels: During your surgery, some or all of your thyroid gland may be removed. This can result in having low thyroid levels in your blood. This can be corrected by medicines that increase your thyroid levels."}
                    }

                },
                              new ExpandableDescription
                {
                    Title = "What else should I know?",
                    //downURL = "downImage.png",
                    //upURL = "upImage.png",
                    IsVisible = false,
                    Descriptions = new ObservableCollection<InnerDescription>
                    {
                        new InnerDescription{description="After your surgery, there will not be a connection between your nose/mouth and your trachea. You will be a “neck breather” and the stoma in your neck will be your only way to breathe. This means that if you require CPR, it will need to be delivered mouth to neck. If you require a breathing tube, it will need to be inserted through your stoma instead of your mouth. When you cough, secretions (mucus) will come out of your stoma, not into your mouth."},
                         new InnerDescription{description="You may not be able to smell anymore because you will not be able to inhale odors through your nose."},
                         new InnerDescription{description="Your taste will be decreased. This is because an important aspect of taste is the ability to smell."},
                         new InnerDescription{description="You will not be able to blow your nose. This is because you will not be able to expel air through your nose. Instead, you should clean secretions with a tissue (a little nose pick never hurts)."},
                         new InnerDescription{description="You will not be able to hold your breath and bear down. Usually you do this by closing your mouth while you try to push. Your stoma will not close and therefore, if you push, air will leave your lungs."},
                         new InnerDescription{description="You will need to learn a new way to speak. A specialist called a speech therapist or a speech pathologist will review your surgery, evaluate you, and describe to you options for producing speech. You should prepare to work with this specialist for months to years as you learn the best way for you to speak. Depending on your surgery, these options include:"},
                         new InnerDescription{description="Esophageal speech: This is where you learn how to swallow and expel air to produce sound."},
                         new InnerDescription{description="Electrolarynx: This is an option to produce speech using an electronic device that acts as an artificial larynx."},
                         new InnerDescription{description="Tracheo-esophageal speech: This is where a valve is created in your stoma that allows air from your lungs to enter your esophagus to help you produce speech."},
                         new InnerDescription{description="Swallowing may be different or the same after your surgery. If you were having trouble swallowing before your surgery, you might find that swallowing after your surgery is easier. Your swallowing will be progressed from liquids, to pureed foods, to soft foods, until you are able to swallow solid foods. The amount of time it takes to be progressed back to your normal diet will depend on how your body heals. Usually, you will be able to start swallowing liquids within 2 weeks of surgery. If you have had previous treatments for your cancer like chemotherapy or radiation, this may take longer."},
                         new InnerDescription{description="You might feel like food or liquid is sticking to the back of your throat when you swallow. If this happens, you can try to give an extra push with the back of your tongue when you start to swallow. You will be taught how to do this with a specialist. Talk to your doctor if you are having trouble swallowing."},
                         new InnerDescription{description="Showering after your surgery will require you to shield your stoma to prevent water from entering your lungs. You will be given a reusable shower shield that you can use during a shower. It is important to keep using this shield every time you shower. Do not submerge yourself in water. You should not swim or take baths with your stoma because water can enter your lungs. If too much water enters your lungs, you can drown. It is also important to think seriously before going on a small boat. These have a higher chance of rolling over and put you at risk for submersion in water."},
                         new InnerDescription{description="You may want to consider getting a MedicAlert bracelet with the words “Neck Breather” on it. This will allow medical personnel to know how to care for your airway in the case that you stop breathing or are unable to tell them about your surgery. You can register for this bracelet at www.medicalert.org."},
                    }

                },
                                      new ExpandableDescription
                {
                    Title = "Caring for your stoma",
                    //downURL = "downImage.png",
                    //upURL = "upImage.png",
                    IsVisible = false,
                    Descriptions = new ObservableCollection<InnerDescription>
                    {
                        new InnerDescription{description="While you are still in the hospital, you will learn how to suction and care for your stoma. Remember, this is the way you are able to breathe so it is important to keep the area clean, moist, and open. Keeping the air delivered through your stoma moist is important. Usually, your mouth and nose humidify the air that you breathe before it enters your lungs. This prevents the natural secretions in your lungs from drying out and creating a plug in your lungs that block the air from going in. While you are in the hospital you will be encouraged to use the humidity collar as often as possible. You will leave the hospital with a portable humidifier that you can use at home. If you want to leave your bed in the hospital, a wet gauze bib may be worn around your neck and over your stoma to allow you to breathe moist air (see below)."},
                         new InnerDescription{description="You will have a laryngectomy tube in your stoma (see above). This is a soft plastic tube that keeps your stoma from getting smaller or closing. You will learn how to insert, clean, and suction this tube while you are in the hospital. It is important to clean this tube regularly to keep it free from secretions. Your doctor will tell you how long you will need this tube."}
                    }

                },
                new ExpandableDescription
                {
                    Title = "Emotions after surgery",
                    //downURL = "downImage.png",
                    //upURL = "upImage.png",
                    IsVisible = false,
                    Descriptions = new ObservableCollection<InnerDescription>
                    {
                        new InnerDescription{description="Surgery for a serious illness can come with a lot of new and upsetting feelings. It is important to understand that this is common and should be addressed. You may experience sadness, anxiety, irritability, anger or other emotions. If you experience any of these, it is a good idea to seek emotional support. Some people find it helpful to talk about these emotions with friends or family while others feel more comfortable talking about them with a healthcare provider. There are many resources available to help you cope with the emotional aspects of cancer and treatment and we are here to help you navigate these emotions."}
                    }
                },
                new ExpandableDescription
                {
                    Title = "How can I help my recovery?",
                    //downURL = "downImage.png",
                    //upURL = "upImage.png",
                    IsVisible = false,
                    Descriptions = new ObservableCollection<InnerDescription>
                    {
                        new InnerDescription{description="An important part of recovery is staying active. Your doctor or nurse will give you instructions on what kinds of activities to avoid and what kinds of activities to do to help your recovery."}
                    }
                },
                new ExpandableDescription
                {
                    Title = "When to call my doctor",
                    //downURL = "downImage.png",
                    //upURL = "upImage.png",
                    IsVisible = false,
                    Descriptions = new ObservableCollection<InnerDescription>
                    {
                        new InnerDescription{description="You should call your doctor or go to the nearest emergency room if you experience any of the following after surgery:"}
                    }
                },
                new ExpandableDescription
                {
                    Title = "Questions to ask your doctor:",
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
        public string Title { get; set; }
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
