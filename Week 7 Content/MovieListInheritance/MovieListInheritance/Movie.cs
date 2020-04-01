using System.Windows;

namespace MovieList
{
    public class Movie
    {
        public string Title
        {
            get;
            set;
        }

        public int ReleaseYear
        {
            get;
            set;
        }

        public virtual void ShowDetails() //What does virtual mean? Virtual is just a keyword used to signify that a derived class can override this method. 
        {
            string infoString = "Title: " + this.Title;
            infoString += "\nRelease Year: " + this.ReleaseYear;
            MessageBox.Show(infoString);
        }

        public Movie() { }

        public Movie(string myTitle, int myReleaseYear)
        {
            this.Title = myTitle;
            this.ReleaseYear = myReleaseYear;
        }
    }
}
