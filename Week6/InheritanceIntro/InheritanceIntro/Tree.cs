using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace InheritanceIntro
{
    class Tree
    {
        public int Rings;
        public double Age;

        public void AgeFinder()
        {
            //I made this formula up
            Age = Rings * 1.5 / 4 + 12; 
            MessageBox.Show("This tree has " + Rings.ToString() + " rings. Therefore, it is " + (Convert.ToInt32(Age)).ToString() + " years old.");
        }

        public Tree()
        {

        }

        public Tree(int rings)
        {
            Rings = rings;
        }
    }
}
