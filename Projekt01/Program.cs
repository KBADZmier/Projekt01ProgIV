
//1.Wczytać dane z pliku hotele.csv z użyciem biblioteki CsvHelper
//2. Wyszukać wszystkie hotele, których nazwa zaczyna się na literę 's'
//3. Obliczyć ile hoteli ma charakter sezonowy
//4. Wyświetlić wszystkie typy charakterów usług bez powtórzeń
//5. Wyświetlić wszystkie kategorie hoteli bez powtórzeń
//6. Wyświetlić hotele, które pochodzą z okolicy Bielska-Białej (numer telefonu zaczyna się 33)
//7.Pogrupować hotele wg kategorii i zwrócić ile hoteli występuje w każdej grupie
//8. Pogrupować hotele wg charakteru usług i zwrócić ile hoteli występuje w każdej grupie


using System.Formats.Asn1;
using System.Globalization;
using System.Reflection.PortableExecutable;
using System.Runtime.CompilerServices;
using System.Text;
using CsvHelper;
using CsvHelper.Configuration;
using CsvHelper.Configuration.Attributes;
using System.IO;
using System.Linq;

namespace projekt01
{

     

    public class Hotele
    {
        [Index(0)]
        public string Lp { get; set; }
        [Index(1)]
        public string NazwaWłasna { get; set; }
        [Index(2)]
        public string Telefon { get; set; }
        [Index(3)]
        public string Email { get; set; }
        [Index(4)]
        public string Charakterystyka { get; set; }
        [Index(5)]
        public string KategoriaObiektu { get; set; }
        [Index(6)]
        public string Rodzaj_Obiektu { get; set; }
        [Index(7)]
        public string Adres { get; set; }
            

    }



    class program
    {


        static void Main(string[] arg)
        {
            //1.Wczytać dane z pliku hotele.csv z użyciem biblioteki CsvHelper
            List<Hotele> hotels = new List<Hotele>();

            using (var reader = new StreamReader(@"C:\\Users\\Bidzk\\source\\repos\\Projekt01\\Projekt01\\bin\\Debug\\net6.0\\hotele.csv ", Encoding.UTF8))
           
               
            {  var csvConfig = new CsvConfiguration(CultureInfo.CurrentCulture)
            { Delimiter = ";",
               
                MissingFieldFound = null


            };
                using (var csv = new CsvReader(reader, csvConfig))
                while (csv.Read())
               {
                    
                    var hotel = csv.GetRecord<Hotele>();
                    
                    hotels.Add(hotel);
                
              }
                ///

                // 2. Wyszukać wszystkie hotele, których nazwa zaczyna się na literę 's'
                var Shotel = hotels.Where(x => x.NazwaWłasna.StartsWith("S"));
                    foreach(var item in Shotel)
                {
                   // Console.WriteLine(item.Lp + ": " + item.NazwaWłasna + ": " + item.Telefon + ": " + item.Email + ": " + item.Charakterystyka + ": "
                  //   + item.Rodzaj_Obiektu +": " + item.KategoriaObiektu+": " + item.Adres);


                }
                // return Shotel;


                //3. Obliczyć ile hoteli ma charakter sezonowy


                var SezHotel = hotels.Where(x => x.Charakterystyka.Contains("sezonowy"));
                var licznik = 0;
                foreach (var item in SezHotel)
                {
                   //  Console.WriteLine(item.Lp + ": " + item.NazwaWłasna + ": " + item.Telefon + ": " + item.Email + ": " + item.Charakterystyka + ": "
                     //  + item.Rodzaj_Obiektu +": " + item.KategoriaObiektu+": " + item.Adres);

                    licznik++;
                    
                }
                Console.WriteLine(licznik);

                //4. Wyświetlić wszystkie typy charakterów usług bez powtórzeń
                //5. Wyświetlić wszystkie kategorie hoteli bez powtórzeń
                //6. Wyświetlić hotele, które pochodzą z okolicy Bielska-Białej (numer telefonu zaczyna się 33)
                //7.Pogrupować hotele wg kategorii i zwrócić ile hoteli występuje w każdej grupie
                //8. Pogrupować hotele wg charakteru usług i zwrócić ile hoteli występuje w każdej grupie


                //    foreach(var item in hotels)
                //   {
                //    Console.WriteLine(item.Lp+": "  + item.NazwaWłasna+": " + item.Telefon+": " + item.Email+": " + item.Charakterystyka+": " 
                //       + item.Rodzaj_Obiektu +": " + item.KategoriaObiektu+": " + item.Adres);

                // }


            }




        }

    }

}
