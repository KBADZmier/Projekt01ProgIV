
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
using CsvHelper;
using CsvHelper.Configuration;
using CsvHelper.Configuration.Attributes;

namespace projekt01
{

     
   [Delimiter(";")]
    public class Hotele
    {
        public int Lp { get; set; }
        public string NazwaWłasna { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public string Charakterystyka { get; set; }
        public string Kategoria { get; set; }
        public string Rodzaj_Obiektu { get; set; }
        public string Adres { get; set; }
            

    }

    public sealed class FooMap : ClassMap<Hotele>
    {
        public FooMap()
        {
            Map(m => m.Lp);
            Map(m => m.NazwaWłasna);
        }
    }

    class program
    {


        static void Main(string[] arg)
        {
             List<Hotele> hotels = new List<Hotele>();

            using (var reader = new StreamReader(@"C:\\Users\\Bidzk\\source\\repos\\Projekt01\\Projekt01\\bin\\Debug\\net6.0\\hotele.csv"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
          //  csv.Configuration.HasHeaderRecord = true;
           //csv.Configuration.Delimiter = ";";
            //var records = csv.GetRecords<hotele>();

                while (csv.Read())
                {
                    var hotel = csv.GetRecord<Hotele>();
                    hotels.Add(hotel);
                
                }
                foreach(var item in hotels)
                {
                    Console.WriteLine(item.Lp  + item.Telefon + item.Email + item.Adres + item.Charakterystyka);

                }
                            
            
            }

            


        }

    }

}