﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;


namespace InheritanceIntro
{
    class Frog : Animal
    {
        public bool isPoisonous; 
        public void Ribbit()
        {
            MessageBox.Show("Ribbit");
        }

        public Frog()
        {


        }
        public Frog(int height, string name, bool IsPoisonous)
        {
            Height = height;
            Name = name;
            isPoisonous = IsPoisonous;
        }
    } 
}
