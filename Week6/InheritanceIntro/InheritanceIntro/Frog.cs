using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;


namespace InheritanceIntro
{
    public class Frog : Animal
    {
        public bool isPoisonous; 

        public Frog()
        {


        }
        public Frog(int height, string name, bool IsPoisonous, int weight)
        {
            Height = height;
            Name = name;
            isPoisonous = IsPoisonous;
            Weight = weight;
        }

        public override void Speak()
        {
            MessageBox.Show("Ribbit");
        }
    } 
}
