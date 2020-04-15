using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace InheritanceIntro
{
    class Duck : Animal
    {

        public override void Speak()
        {
            MessageBox.Show("Quack");
        }

        public Duck()
        {

        }

        public Duck(int height, string name, int weight)
        {
            Height = height;
            Name = name;
            Weight = weight;
        }
    }
}
