using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MovieListInheritance
{
    class AnimatedMovie : MovieList.Movie
    {
        public string AnimationStudio //am I doing the properties right? 
        {
            get;
            set;
        }

        public string AnimationType
        {
            get;
            set;
        }

        public override void ShowDetails() 
        {
            string infoString = "Title: " + this.Title;
            infoString += "\nRelease Year: " + this.ReleaseYear;
            infoString += "\nAnimation Studio: " + this.AnimationStudio;
            infoString += "\nAnimationType: " + this.AnimationType;
            MessageBox.Show(infoString);
        }
        public AnimatedMovie() { }

        public AnimatedMovie(string title, int releaseYear, string animationStudio, string animationType)
        {
            this.Title = title;
            this.ReleaseYear = releaseYear;
            this.AnimationStudio = animationStudio;
            this.AnimationType = animationType;
        }
    }
}
