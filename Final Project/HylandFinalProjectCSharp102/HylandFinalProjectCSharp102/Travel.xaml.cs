using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace HylandFinalProjectCSharp102
{
    /// <summary>
    /// Interaction logic for Travel.xaml
    /// </summary>
    public partial class Travel : Window
    {
        Country Countries = new Country();
        public string countrySelected;
        public int countryID;
        bool countryValid;

        public Travel()
        {
            InitializeComponent();
        }

        public Travel(TextBlock txtinformation)
        {
            InitializeComponent();
            this.Information = txtinformation;
        }

        public TextBlock Information
        {
            get;
            set;
        }

        private void btnEnter_Click(object sender, RoutedEventArgs e)
        {

            countryValid = false;
            countrySelected = txtUserInput.Text.ToString().ToUpper();
            for (int i = 0; i < 15; i++) //15 is the length of the countries list. Keep that in mind. 
            {
                if (countrySelected == Country.countryNames[i].ToUpper())
                {
                    countryValid = true;
                    countryID = i;
                    break;
                }
            }
            if (countryValid)
            {
                txtUserInput.Clear();
                MainWindow.currentCountryFacts = Country.countryFacts[countryID]; 
                Information.Text = MainWindow.currentCountryFacts;
            }
            else
            {
                MessageBox.Show("Please enter a valid country.");
            }
        }
    }
}
