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
using MovieListInheritance; //Why do I have to do this?

namespace MovieList
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static ObservableCollection<Movie> MovieList;
        public string webpageTitle;
        public char[] webpageTitleArray;
        AddMovie AddMovieForm = new AddMovie();

        public MainWindow()
        {
            InitializeComponent();

            MovieList = new ObservableCollection<Movie>();
            lvMovies.ItemsSource = MovieList;
            
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            //try
            //{
            //    Movie movieToAdd = new Movie(titleInput.Text, int.Parse(releaseYearInput.Text));

            //    MovieList.Add(movieToAdd);

            //    titleInput.Clear();
            //    releaseYearInput.Clear();
            //}
            //catch (System.FormatException)
            //{
            //    MessageBox.Show("Please enter a valid year");
            //}
            AddMovie AddMovieForm = new AddMovie();
            AddMovieForm.Show();
        }

        private void ShowButton_Click(object sender, RoutedEventArgs e)
        {
            foreach (Movie m in MovieList)
            {
                webpageTitle = "";
                //m.ShowDetails();
                webpageTitleArray = m.Title.ToCharArray();
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

        private void lvMovies_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Movie selectedMovie = lvMovies.SelectedItem as Movie;
            if (selectedMovie != null)
            {
                selectedMovie.ShowDetails();
            }
        }

        private void AddAnimatedButton_Click(object sender, RoutedEventArgs e)
        {
            //string animationStudio = animationStudioInput.Text;
            //string animationType = animationTypeInput.Text;
            //MovieListInheritance.AnimatedMovie animatedMovieToAdd = new MovieListInheritance.AnimatedMovie(titleInput.Text, Convert.ToInt32(releaseYearInput.Text), animationStudio, animationType);
            //
            ////Why do I have to add the MovieListInheritance.? MAKE SURE TO ASK THIS QUESTION
            //
            //MovieList.Add(animatedMovieToAdd);
            //titleInput.Clear();
            //releaseYearInput.Clear();
            //animationStudioInput.Clear();
            //animationTypeInput.Clear();

            AddAnimatedMovie AddAnimatedForm = new AddAnimatedMovie();
            AddAnimatedForm.Show();
        }
    }
}
