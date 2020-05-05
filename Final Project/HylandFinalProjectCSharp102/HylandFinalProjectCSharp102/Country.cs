using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HylandFinalProjectCSharp102
{
    public class Country
    {
        public static List<string> countryNames = new List<string>()
        { "America", "Brazil", "Peru", "Netherlands", "United Kingdom", "Japan", "Poland", "India", "Australia"};
        //public static List<string> countryFacts = new List<string>() 
        //{ "The major characteristic of the United States is probably its great variety. Its physical environment ranges from the Arctic to the subtropical, from the moist rain forest to the arid desert, from the rugged mountain peak to the flat prairie. Although the total population of the United States is large by world standards, its overall population density is relatively low. The country embraces some of the world’s largest urban concentrations as well as some of the most extensive areas that are almost devoid of habitation.",
        //"Brazil is the fifth most-populous country on Earth and accounts for one-third of Latin America’s population. Most of the inhabitants of Brazil are concentrated along the eastern seaboard, although its capital, Brasília, is located far inland and increasing numbers of migrants are moving to the interior. Rio de Janeiro, in the eyes of many of the world, continues to be the preeminent icon of Brazil. The nation’s burgeoning cities, huge hydroelectric and industrial complexes, mines, and fertile farmlands make it one of the world’s major economies. However, Brazil struggles with extreme social inequalities, environmental degradation, intermittent financial crises, and a sometimes deadlocked political system.",
        //"Peru is essentially a tropical country, with its northern tip nearly touching the Equator. Despite its tropical location, a great diversity of climate, of way of life, and of economic activity is brought about by the extremes of elevation and by the southwest winds that sweep in across the cold Peru Current (or Humboldt Current), which flows along its Pacific shoreline. The immense difficulties of travel posed by the Andes have long impeded national unity. Iquitos, on the upper Amazon, lies only about 600 miles (965 km) northeast of Lima, the capital, but, before the airplane, travelers between the cities often chose a 7,000-mile (11,250-km) trip via the Amazon, the Atlantic and Caribbean, the Isthmus of Panama, and the Pacific, rather than the shorter mountain route.",
        //"“Netherlands” means low-lying country; the name Holland (from Houtland, or “Wooded Land”) was originally given to one of the medieval cores of what later became the modern state and is still used for 2 of its 12 provinces (Noord-Holland and Zuid-Holland). A parliamentary democracy under a constitutional monarch, the kingdom includes its former colonies in the Lesser Antilles: Aruba, Bonaire, Curaçao, Saba, Sint Eustatius, and Sint Maarten. The capital is Amsterdam and the seat of government The Hague. The country is indeed low-lying and remarkably flat, with large expanses of marshlands.",
        //"United Kingdom, island country located off the northwestern coast of mainland Europe. The United Kingdom comprises the whole of the island of Great Britain—which contains England, Wales, and Scotland—as well as the northern portion of the island of Ireland. The name Britain is sometimes used to refer to the United Kingdom as a whole. The capital is London, which is among the world’s leading commercial, financial, and cultural centres. Other major cities include Birmingham, Liverpool, and Manchester in England, Belfast and Londonderry in Northern Ireland, Edinburgh and Glasgow in Scotland, and Swansea and Cardiff in Wales.",
        //"The Japanese landscape is rugged, with more than four-fifths of the land surface consisting of mountains. There are many active and dormant volcanoes, including Mount Fuji (Fuji-san), which, at an elevation of 12,388 feet (3,776 metres), is Japan’s highest mountain. Abundant precipitation and the generally mild temperatures throughout most of the country have produced a lush vegetation cover and, despite the mountainous terrain and generally poor soils, have made it possible to raise a variety of crops. Japan has a large and, to a great extent, ethnically homogeneous population, which is heavily concentrated in the low-lying areas along the Pacific coast of Honshu.",
        //"Poland is located at a geographic crossroads that links the forested lands of northwestern Europe to the sea lanes of the Atlantic Ocean and the fertile plains of the Eurasian frontier. Now bounded by seven nations, Poland has waxed and waned over the centuries, buffeted by the forces of regional history. In the early Middle Ages, Poland’s small principalities and townships were subjugated by successive waves of invaders, from Germans and Balts to Mongols. In the mid-1500s, united Poland was the largest state in Europe and perhaps the continent’s most powerful nation. Yet two and a half centuries later, during the Partitions of Poland (1772–1918), it disappeared, parceled out among the contending empires of Russia, Prussia, and Austria.",
        //"India's. capital is New Delhi, built in the 20th century just south of the historic hub of Old Delhi to serve as India’s administrative centre. It is known from archaeological evidence that a highly sophisticated urbanized culture—the Indus civilization—dominated the northwestern part of the subcontinent from about 2600 to 2000 bce. From that period on, India functioned as a virtually self-contained political and cultural arena, which gave rise to a distinctive tradition that was associated primarily with Hinduism, the roots of which can largely be traced to the Indus civilization..",
        //"Australia, the smallest continent and one of the largest countries on Earth, lying between the Pacific and Indian oceans in the Southern Hemisphere. Australia’s capital is Canberra, located in the southeast between the larger and more important economic and cultural centres of Sydney and Melbourne. The Australian mainland extends from west to east for nearly 2,500 miles (4,000 km) and from Cape York Peninsula in the northeast to Wilsons Promontory in the southeast for nearly 2,000 miles (3,200 km)."
        //}; //These are the text descriptions that will be put in the "Information" panel on the Main Window...if I can figure out how to do so.
        //public static List<string> countryClues = new List<string> { 
        //"the Statue of Liberty",
        //"Rio de Janiero",
        //"quipu",
        //"Delta Works",
        //"Big Ben",
        //"Shinto shrine",
        //"Warsaw",
        //"Taj Mahal",
        //"kangaroo",
        //} ;
        public string countryName
        {
            get;
            set;
        }

        public string countryFact
        {
            get;
            set;
        }

        public string countryClue
        {
            get;
            set;
        }
        public Country()
        {

        }

        public Country(string countryname, string countryfact, string countryclue)
        {
            this.countryName = countryname;
            this.countryFact = countryfact;
            this.countryClue = countryclue;
        }
    }
}
