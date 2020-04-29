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
    /// Interaction logic for Atlas.xaml
    /// </summary>
    public partial class Atlas : Window
    {
        public string webpageTitle; //used this code from the Movie List project
        public char[] webpageTitleArray;
        public Atlas()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            webpageTitle = "";
            //m.ShowDetails();
            webpageTitleArray = atlasInput.Text.ToCharArray();
            for (int i = 0; i < webpageTitleArray.Length; i++)
            {
                if (webpageTitleArray[i] == ' ')
                {
                    webpageTitleArray[i] = '_';
                    webpageTitle += webpageTitleArray[i].ToString();
                }
                else
                {
                    webpageTitle += webpageTitleArray[i].ToString();
                }
            }
            System.Diagnostics.Process.Start("http://www.wikipedia.org/wiki/" + webpageTitle);
        }
    }
}
