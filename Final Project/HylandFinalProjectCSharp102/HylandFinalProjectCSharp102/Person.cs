using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HylandFinalProjectCSharp102
{
    class Person
    {
        public static List<string> possibleFirstNames = new List<String>() { "Aaron", "Alexis", "Billy", "Bob", "Donald", "Elizabeth", "Francis", "George", "Heather", "Jim", "Kevin", "Mary", "Matilda", "Oswald", "Priscilla", "Rachel", "Sam", "Zach" };
        public static List<string> possibleLastNames = new List<String>() { "Abba", "Cruz", "Jefferson", "Duff", "Lee", "Monroe", "McDonald", "Hubbold", "Jones", "Lynn", "Johnson", "Shut", "Spring", "Smith", "Trump", "Nagawa", "Roosevelt", "Patton" };
        public static List<string> colors = new List<string>() { "brown", "black", "blue", "green" , "yellow", "white", "purple", "orange" };
        public static List<string> height = new List<string>() { "short", "tall" };
        public static List<string> clothes = new List<string>() { "gloves", "shirt", "coat", "jacket", "hat", "shoes" };
        public static List<string> age = new List<string>() { "old", "young", "middle-aged" };

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

        public Person(string name, string information) //for people getting asked by the player
        {
            this.Name = name;
            this.Information = information;
        }
    }
}
