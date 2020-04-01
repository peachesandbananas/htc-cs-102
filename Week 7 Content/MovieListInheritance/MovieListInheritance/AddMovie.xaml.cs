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
using System.Windows.Shapes;
using MovieList; //why do I have to do this?
using MovieListInheritance;

namespace MovieListInheritance
{
    /// <summary>
    /// Interaction logic for AddMovie.xaml
    /// </summary>
    public partial class AddMovie : Window 
    {

        public AddMovie()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MovieTitle = titleInput.Text;
                ReleaseYear = Convert.ToInt32(releaseYearInput.Text);
                titleInput.Clear();
                releaseYearInput.Clear();
                Movie movieToAdd = new Movie(MovieTitle, ReleaseYear);
                MainWindow.MovieList.Add(movieToAdd);

            }
            catch (System.FormatException)
            {
                MessageBox.Show("Please enter a valid year");
            }
        }

        public string MovieTitle
        {
            get;
            set;
        }

        public int ReleaseYear
        {
            get;
            set;
        }

        public AddMovie(string title, int releaseYear)
        {
            this.MovieTitle = title;
            this.ReleaseYear = releaseYear;
        }
    }
}
