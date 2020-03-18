using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace InheritanceIntro
{
    class Kangaroo : Animal
    {
        public int Weight; //You will see why this matters later
        public void Box()
        {
            if (Weight < 50)
            {
                MessageBox.Show("One punch and it's over for the kangaroo! Not even close.");
            }
            else if (Weight >= 50 && Weight < 100)
            {
                MessageBox.Show("It's a tough one but you win the fight. And you got some scars to look cool!");
            }
            else if (Weight >= 100 && Weight < 200)
            {
                MessageBox.Show("All you remember is the kangaroo looking down at you and then...lights out! Lucky you survived.");
            }
            else if (Weight >= 200)
            {
                MessageBox.Show("You jump out of the ring and run for the hills! No kangaroo could be that monstrously large.");
            }
        }

        public Kangaroo(int weight)
        {
            Weight = weight;
        }

        public Kangaroo(int height, string name)
        {
            Height = height;
            Name = name;
        }

    }
}
