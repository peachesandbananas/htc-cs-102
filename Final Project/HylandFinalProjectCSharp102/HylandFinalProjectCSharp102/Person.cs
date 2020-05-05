using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace HylandFinalProjectCSharp102
{
    public class Person
    {
        public static int countryID = 0;
        static Random rnd = new Random();

        public List<string> possibleFirstNames = new List<String>() { "Aaron", "Alexis", "Billy", "Bob", "Donald", "Elizabeth", "Francis", "George", "Heather", "Jim", "Kevin", "Mary", "Matilda", "Oswald", "Priscilla", "Rachel", "Sam", "Zach" };
        public List<string> possibleLastNames = new List<String>() { "Abba", "Cruz", "Jefferson", "Duff", "Lee", "Monroe", "McDonald", "Hubbold", "Jones", "Lynn", "Johnson", "Shut", "Spring", "Smith", "Trump", "Nagawa", "Roosevelt", "Patton" };
        //public List<string> colors = new List<string>() { "brown", "black", "blue", "green" , "yellow", "white", "purple", "orange" };
        //public List<string> height = new List<string>() { "short", "tall" };
        //public List<string> clothes = new List<string>() { "gloves", "shirt", "coat", "jacket", "hat", "shoes" };
        //public List<string> age = new List<string>() { "old", "young", "middle-aged" };
        public List<string> wrongRumors = new List<string>() { //List length of 12
        "Sorry, I've never heard of that person.",
        "Who?",
        "No idea, sorry.",
        "What?",
        "Look, I've got places to be. Bye!",
        "Don't know, don't care.",
        "That name doesn't ring a bell.",
        "Quit wasting my time!",
        "Hmm, I think I read about them in the National Enquirer.",
        "Yeah, I saw 'em...on the news last night.",
        "I don't think I've seen that person, but my friend has. He lives in that dark alley over there, the one with all the stains and broken glass on the ground. You should definitely check it out.",
        "I'm having a bad day, don't even bother."};

        public List<string> correctRumors = new List<string>(){
        "I saw them carrying a book that read: ",
        "They were asking around about: ",
        "They were looking for: ",
        "I overheard them mentioning: ",
        "They were shouting about: ",
        };

        public string Name
        {
            get;
            set;
        }

        public string Information
        {
            get;
            set;
        }

        public Person()
        {

        }

        public Person(string name) //for people getting asked by the player
        {
            this.Name = name;
        }

        public virtual void Speak(TextBlock txtInformation, Criminal c)
        {
            string whatSay = "";
            if (MainWindow.correctCountry)
            {
                switch (MainWindow.crooksCaught) //inefficient, is there a better way to tie this up?
                {
                    case 0:
                        determineCountryID(MainWindow.c1.resCountry);
                        whatSay = correctRumors[rnd.Next(0, 4)] + MainWindow.worldCountries[countryID].countryClue;
                        break;
                    case 1:
                        determineCountryID(MainWindow.c2.resCountry);
                        whatSay = correctRumors[rnd.Next(0, 4)] + MainWindow.worldCountries[countryID].countryClue;
                        break;
                    case 2:
                        determineCountryID(MainWindow.cS.resCountry);
                        whatSay = correctRumors[rnd.Next(0, 4)] + MainWindow.worldCountries[countryID].countryClue;
                        break;
                    default:
                        MessageBox.Show("Hmm, this shouldn't have happened. Restart the game.");
                        break;
                }
                whatSay += ".";
            }
            else
            {
                whatSay = wrongRumors[rnd.Next(0,11)];
            }
            whatSay = Name + " says, \"" + whatSay + "\"";
            txtInformation.Text = whatSay;
        }

        public static void determineCountryID(string countryname)
        {
            countryID = -1;
            foreach (Country c in MainWindow.worldCountries)
            {
                if (countryname.ToUpper() == c.countryName.ToUpper())
                {
                    countryID = MainWindow.worldCountries.IndexOf(c);
                }
            }
            if (countryID == -1)
            {
                Travel.countryValid = false;
            }
            else
            {
                Travel.countryValid = true;
            }
        }
    }
}
