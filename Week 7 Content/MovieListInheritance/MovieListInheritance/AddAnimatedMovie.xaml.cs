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
using MovieList;
using MovieListInheritance;

namespace MovieListInheritance
{
    /// <summary>
    /// Interaction logic for AddAnimatedMovie.xaml
    /// </summary>
    public partial class AddAnimatedMovie : Window
    {
        public AddAnimatedMovie()
        {
            InitializeComponent();
        }

        private void AddAnimatedButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MovieTitle = titleInput.Text;
                ReleaseYear = Convert.ToInt32(releaseYearInput.Text);
                AnimationStudio = animationStudioInput.Text;
                AnimationType = animationTypeInput.Text;
                titleInput.Clear();
                releaseYearInput.Clear();
                animationStudioInput.Clear();
                animationTypeInput.Clear();
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

        public string AnimationStudio
        {
            get;
            set;
        }

        public string AnimationType
        {
            get;
            set;
        }

        public AddAnimatedMovie(string title, int releaseYear, string animationStudio, string animationType)
        {
            this.MovieTitle = title;
            this.ReleaseYear = releaseYear;
            this.AnimationStudio = animationStudio;
            this.AnimationType = animationType;
        }
    }
}
