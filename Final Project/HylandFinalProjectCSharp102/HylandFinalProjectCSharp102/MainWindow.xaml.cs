using System;
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

namespace HylandFinalProjectCSharp102
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static Random rnd = new Random();
        static Person p = new Person();
        public string currentCountry;
        public static string currentCountryFacts;
        public int currentHour;
        public int peopleAsked = 0;
        Criminal c1 = new Criminal(p);
        Criminal c2 = new Criminal(p);
        Criminal c3 = new Criminal(p);

        public MainWindow()
        {
            InitializeComponent();

        }

        private void Atlas_Click(object sender, RoutedEventArgs e)
        {
            Atlas atlas = new Atlas();
            atlas.Show();
        }

        private void btnTravel_Click(object sender, RoutedEventArgs e)
        {
            Travel travel = new Travel(txtInformation);
            travel.Show();
        }

        private void btnAsk_Click(object sender, RoutedEventArgs e)
        {
            Person interrogated = new Person(Person.possibleFirstNames[rnd.Next(0,17)] + " " + Person.possibleLastNames[rnd.Next(0,17)],"ADADADADADADADADADADADADA"); //MAJOR PLACEHOLDER HERE
            if (peopleAsked == 3)
            {
                MessageBox.Show("Unfortunately, nobody else in the area knows anything about the case.");
            }
            else
            {
                txtInformation.Text = interrogated.Name.ToString() + " says: " + interrogated.Information;
                peopleAsked += 1;
                currentHour += 1;
            }
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
