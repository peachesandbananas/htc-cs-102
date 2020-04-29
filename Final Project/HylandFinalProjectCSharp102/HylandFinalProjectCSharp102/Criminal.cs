using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HylandFinalProjectCSharp102
{
    class Criminal : Person
    {
        static Random rnd = new Random();

        public Criminal()
        {

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

        public Criminal(Person p)
        {
            this.Name = Person.possibleFirstNames[rnd.Next(0,17)] + " " + Person.possibleFirstNames[rnd.Next(0,17)];
            this.eyeColor = Person.colors[rnd.Next(0,3)];
            this.hairColor = Person.colors[rnd.Next(0, 5)];
            this.Height = Person.height[rnd.Next(0,1)];
            this.Clothes = Person.colors[rnd.Next(0,7)];
            this.Age = Person.age[rnd.Next(0,2)];

        }
    }
}
