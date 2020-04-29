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

namespace InheritanceIntro
{
    /// <summary>
    /// Interaction logic for AnimalInfo.xaml
    /// </summary>
    public partial class AnimalInfo : Window
    {
        public AnimalInfo(Animal animal)
        {
            InitializeComponent();
            //old method
            //
            //if (animal.Name == "Kermit")
            //{
            //    AnimalImage.Source = new BitmapImage(new Uri(@"D:\dell_kev_dec122019\kxu\Hyland\C# 102\Polymorphism Images\kermit.jfif"));
            //}
            //if (animal.Name == "Rolf")
            //{
            //    AnimalImage.Source = new BitmapImage(new Uri(@"D:\dell_kev_dec122019\kxu\Hyland\C# 102\Polymorphism Images\kermit.jfif"));
            //} 
            AnimalImage.Source = new BitmapImage(new Uri(@"D:\dell_kev_dec122019\kxu\Hyland\C# 102\Polymorphism Images\" + animal.Name + ".png"));
            AnimalInformation.Content = animal.Name + " weighs " + animal.Weight.ToString() + " pounds and is " + animal.Height.ToString() + " feet tall.";
        }
    }
}
