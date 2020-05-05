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
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows;

namespace HylandFinalProjectCSharp102
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static Random rnd = new Random();
        static Person p = new Person("");
        static Person b = new Person("Benny Alamo");
        public static string currentCountry;
        public static string currentCountryFacts;
        public static int currentHour; //add in functionality for this
        public static bool personAsked = false;
        public static int crooksCaught = 0;
        public static bool correctCountry = true;
        public static string testCountry;

        //Creation of the countries as objects. Brace yourself.
        public static Country America = new Country("America", "The major characteristic of the United States is probably its great variety. Its physical environment ranges from the Arctic to the subtropical, from the moist rain forest to the arid desert, from the rugged mountain peak to the flat prairie. Although the total population of the United States is large by world standards, its overall population density is relatively low. The country embraces some of the world’s largest urban concentrations as well as some of the most extensive areas that are almost devoid of habitation.", "the Statue of Liberty");
        public static Country Brazil = new Country("Brazil", "Brazil is the fifth most-populous country on Earth and accounts for one-third of Latin America’s population. Most of the inhabitants of Brazil are concentrated along the eastern seaboard, although its capital, Brasília, is located far inland and increasing numbers of migrants are moving to the interior. Rio de Janeiro, in the eyes of many of the world, continues to be the preeminent icon of Brazil. The nation’s burgeoning cities, huge hydroelectric and industrial complexes, mines, and fertile farmlands make it one of the world’s major economies.", "Rio de Janeiro");
        public static Country Peru = new Country("Peru", "Peru is essentially a tropical country, with its northern tip nearly touching the Equator. The immense difficulties of travel posed by the Andes have long impeded national unity. Iquitos, on the upper Amazon, lies only about 600 miles (965 km) northeast of Lima, the capital, but, before the airplane, travelers between the cities often chose a 7,000-mile (11,250-km) trip via the Amazon, the Atlantic and Caribbean, the Isthmus of Panama, and the Pacific, rather than the shorter mountain route.", "quipu");
        public static Country Netherlands = new Country("Netherlands", "Netherlands means low-lying country; the name Holland (from Houtland, or “Wooded Land”) was originally given to one of the medieval cores of what later became the modern state and is still used for 2 of its 12 provinces (Noord-Holland and Zuid-Holland). A parliamentary democracy under a constitutional monarch, the kingdom includes its former colonies in the Lesser Antilles: Aruba, Bonaire, Curaçao, Saba, Sint Eustatius, and Sint Maarten. The capital is Amsterdam and the seat of government The Hague.", "Delta Works");
        public static Country UnitedKingdom = new Country("United Kingdom", "United Kingdom, island country located off the northwestern coast of mainland Europe. The United Kingdom comprises the whole of the island of Great Britain—which contains England, Wales, and Scotland—as well as the northern portion of the island of Ireland. The name Britain is sometimes used to refer to the United Kingdom as a whole. The capital is London, which is among the world’s leading commercial, financial, and cultural centres.", "Big Ben");
        public static Country Japan = new Country("Japan", "The Japanese landscape is rugged, with more than four-fifths of the land surface consisting of mountains. There are many active and dormant volcanoes, including Mount Fuji (Fuji-san), which, at an elevation of 12,388 feet (3,776 metres), is Japan’s highest mountain. Abundant precipitation and the generally mild temperatures throughout most of the country have produced a lush vegetation cover and, despite the mountainous terrain and generally poor soils, have made it possible to raise a variety of crops.", "Shinto shrine");
        public static Country Poland = new Country("Poland", "Poland is located at a geographic crossroads that links the forested lands of northwestern Europe to the sea lanes of the Atlantic Ocean and the fertile plains of the Eurasian frontier. Now bounded by seven nations, Poland has waxed and waned over the centuries, buffeted by the forces of regional history. In the early Middle Ages, Poland’s small principalities and townships were subjugated by successive waves of invaders, from Germans and Balts to Mongols. In the mid-1500s, united Poland was the largest state in Europe and perhaps the continent’s most powerful nation.", "Warsaw");
        public static Country India = new Country("India", "India's capital is New Delhi, built in the 20th century just south of the historic hub of Old Delhi to serve as India’s administrative centre. It is known from archaeological evidence that a highly sophisticated urbanized culture—the Indus civilization—dominated the northwestern part of the subcontinent from about 2600 to 2000 bce. From that period on, India functioned as a virtually self-contained political and cultural arena, which gave rise to a distinctive tradition that was associated primarily with Hinduism, the roots of which can largely be traced to the Indus civilization.", "Taj Mahal");
        public static Country Australia = new Country("Australia", "Australia, the smallest continent and one of the largest countries on Earth, lying between the Pacific and Indian oceans in the Southern Hemisphere. Australia’s capital is Canberra, located in the southeast between the larger and more important economic and cultural centres of Sydney and Melbourne. The Australian mainland extends from west to east for nearly 2,500 miles (4,000 km) and from Cape York Peninsula in the northeast to Wilsons Promontory in the southeast for nearly 2,000 miles (3,200 km).", "kangaroo");
        public static List<Country> worldCountries = new List<Country>() { America, Brazil, Peru, Netherlands, UnitedKingdom, Japan, Poland, India, Australia };
        public static Criminal c1 = new Criminal(p, Country.countryNames[rnd.Next(0, Country.countryNames.Count() - 1)]);
        public static Criminal c2 = new Criminal(p, Country.countryNames[rnd.Next(0, Country.countryNames.Count() - 1)]);
        public static Criminal cS = new Criminal(b, Country.countryNames[rnd.Next(0, Country.countryNames.Count() - 1)]); //Carmen Sandiego
        public static List<Criminal> numCrooks = new List<Criminal>() { c1, c2, cS };
        public MainWindow()
        {
            InitializeComponent();
            imgCountry.Source = new BitmapImage(new Uri(@"D:\dell_kev_dec122019\kxu\Hyland\C# 102\Final Project\Images\CHIEF.png"));
            txtInformation.Text = "A major heist has been pulled off by international criminal Benny Alamo, as well as his associates " + c1.Name + ", and " + c2.Name + ". They've scattered around the world, and INTERPOL needs you to find them.";
        }

        private void Atlas_Click(object sender, RoutedEventArgs e)
        {
            Atlas atlas = new Atlas();
            atlas.Show();
        }

        private void btnTravel_Click(object sender, RoutedEventArgs e)
        {
            Travel travel = new Travel(txtInformation, imgCountry);
            travel.Show();
        }

        private void btnAsk_Click(object sender, RoutedEventArgs e)
        {
            Person interrogated = new Person(p.possibleFirstNames[rnd.Next(0,17)] + " " + p.possibleLastNames[rnd.Next(0,17)]); //MAJOR PLACEHOLDER HERE
            interrogated.Speak(txtInformation, c1);
        }

        private void btnArrest_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
