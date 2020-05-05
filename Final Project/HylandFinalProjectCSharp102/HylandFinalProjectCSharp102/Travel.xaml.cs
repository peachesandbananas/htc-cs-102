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
        public static bool countryValid;

        public Travel()
        {
            InitializeComponent();
        }

        public Travel(TextBlock txtinformation, Image picture)
        {
            InitializeComponent();
            this.Information = txtinformation;
            this.Picture = picture;
        }

        public TextBlock Information
        {
            get;
            set;
        }

        public Image Picture
        {
            get;
            set;
        }
        private void btnEnter_Click(object sender, RoutedEventArgs e)
        {

            countryValid = false;
            countrySelected = txtUserInput.Text.ToString().ToUpper();
            Person.determineCountryID(countrySelected);
            txtUserInput.Clear();
            if (countryValid)
            {
                MainWindow.currentCountryFacts = MainWindow.worldCountries[Person.countryID].countryFact.ToString();
                Information.Text = MainWindow.currentCountryFacts;
                Picture.Source = new BitmapImage(new Uri(@"D:\dell_kev_dec122019\kxu\Hyland\C# 102\Final Project\Images\" + countrySelected + ".png")); 
                Close();
                switch (MainWindow.crooksCaught) //inefficient, is there a better way to tie this up?
                {
                    case 0:
                        if (countrySelected == MainWindow.c1.resCountry.ToUpper())
                        {
                            MainWindow.correctCountry = true;
                            MainWindow.c1.Speak(Information, MainWindow.c2);
                            MainWindow.crooksCaught++;
                        }
                        else
                        {
                            MainWindow.correctCountry = false;
                        }
                        break;
                    case 1:
                        if (countrySelected == MainWindow.c2.resCountry.ToUpper())
                        {
                            MainWindow.correctCountry = true;
                            MainWindow.c2.Speak(Information, MainWindow.cS);
                            MainWindow.crooksCaught++;
                        }
                        else
                        {
                            MainWindow.correctCountry = false;
                        }
                        break;
                    case 2:
                        if (countrySelected == MainWindow.cS.resCountry.ToUpper())
                        {
                            MainWindow.correctCountry = true;
                            MainWindow.cS.Speak(Information, MainWindow.cS);//is there a way to just ignore the 2nd parameter? To just say "nothing"?
                            //Special case here
                        }
                        else
                        {
                            MainWindow.correctCountry = false;
                        }
                        break;
                    default:
                        MessageBox.Show("Hmm, this shouldn't have happened. Restart the game.");
                        break;
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid country.");
            }
        }
    }
}
