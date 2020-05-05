using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace HylandFinalProjectCSharp102
{
    public class Criminal : Person
    {
        static Random rnd = new Random();

        public Criminal()
        {

        }

        public string resCountry
        {
            get;
            set;
        }

        public string eyeColor
        {
            get;
            set;
        }

        public string hairColor
        {
            get;
            set;
        }

        public string Height
        {
            get;
            set;
        }

        public string Clothes
        {
            get;
            set;
        }

        public string Age
        {
            get;
            set;
        }

        public Criminal(Person p, string rescountry)
        {
            if (p.Name == "")
            {
                this.Name = p.possibleFirstNames[rnd.Next(0, 17)] + " " + p.possibleFirstNames[rnd.Next(0, 17)];
            }
            else
            {
                this.Name = p.Name;
            }
            //this.eyeColor = p.colors[rnd.Next(0,3)];
            //this.hairColor = p.colors[rnd.Next(0, 5)];
            //this.Height = p.height[rnd.Next(0,1)];
            //this.Clothes = p.colors[rnd.Next(0,7)];
            //this.Age = p.age[rnd.Next(0,2)];
            this.resCountry = rescountry;
        }

        public override void Speak(TextBlock txtInformation, Criminal c) //CHANGE LATER
        {
            if (MainWindow.crooksCaught < 2)
            {
                MessageBox.Show("You've arrived at the right location and " + Name + " has been apprehended. Good work! Now find " + c.Name + ".");
            }
            else
            {
                MessageBox.Show("You've done it! You've caught the man himself: Benny Alamo! Congratulations! Unfortunately, budget cuts at INTERPOL mean we can't you give you the reward, but a pat on the back should be more than enough. Good job.");
            }
        }
    }
}
