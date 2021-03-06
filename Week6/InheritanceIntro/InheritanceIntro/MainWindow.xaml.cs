﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace InheritanceIntro
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Animal> Animals;

        public MainWindow()
        {
            InitializeComponent();
            Animals = new ObservableCollection<Animal>();

            Frog frog = new Frog(4, "Kermit", false, 3);
            Dog dog = new Dog("Muppet", 20, "Rolf", 50);
            Duck duck = new Duck(9, "Donald", 30);

            Dog dogC = new Dog("Muppet", 200, "Clifford", 1000);
            Duck duckD = new Duck(5, "Daffy", 60); 
            Frog frogJ = new Frog(3, "Jeremiah", false, 15);

            Animals.Add(frog);
            Animals.Add(dog);
            Animals.Add(duck);
            Animals.Add(dogC);
            Animals.Add(duckD);
            Animals.Add(frogJ);

            lvAnimals.ItemsSource = Animals;
        }

        //private void Bark_Button_Click(object sender, RoutedEventArgs e)
        //{
        //    Dog dog = new Dog();
        //    dog.Bark();
        //}

        private void SayName_Button_Click(object sender, RoutedEventArgs e)
        {
            foreach (Animal a in Animals)
            {
                a.SayName();
            }

            //// Define a new List of dogs
            //List<Dog> dogs = new List<Dog>();
            
            //// Instantiate some dog objects
            //Dog dog1 = new Dog("Muppet", 20, "Rolf");
            //Dog dog2 = new Dog("Golden Retriever", 30, "Air Bud");

            //// Add the dogs to the list
            //dogs.Add(dog1);
            //dogs.Add(dog2);

            //// Loop through the list and call a method on the objects
            //foreach (Dog d in dogs)
            //{
            //    d.SayName();
            //}

            //Duck duck = new Duck(28, "Daffy");
            //duck.SayName();

            //Frog frog = new Frog(14, "Kermit", false);
            //frog.SayName();

            //Kangaroo roo = new Kangaroo(5, "Jerry");
            //roo.SayName();
        }

        //private void Quack_Button_Click(object sender, RoutedEventArgs e)
        //{
        //    Duck duck = new Duck();
        //    duck.Quack();
        //}

        //private void Ribbit_Button_Click(object sender, RoutedEventArgs e)
        //{
        //    Frog frog = new Frog();
        //    frog.Ribbit();
        //}

        private void Box_Button_Click(object sender, RoutedEventArgs e)
        {
            Random rand = new Random();
            int pounds = rand.Next(1, 300);
            Kangaroo roo = new Kangaroo(pounds);
            roo.Box();
        }

        private void AgeFinder_Button_Click(object sender, RoutedEventArgs e)
        {
            Random rand = new Random();
            int rings = rand.Next(1, 50);
            Tree tree = new Tree(rings);
            tree.AgeFinder();
        }

        private void lvAnimals_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Animal selectedAnimal = lvAnimals.SelectedItem as Animal;
            if (selectedAnimal != null)
            {
                AnimalInfo AnimalInfoForm = new AnimalInfo(selectedAnimal);
                AnimalInfoForm.Show();
            }

        }
    }
}
