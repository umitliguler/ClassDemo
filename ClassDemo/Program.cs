using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var ayakkabi1 = new Ayakkabi("Kırmızı Kundura");
            Console.WriteLine(ayakkabi1.Marka);
            ayakkabi1.Numara = -70;



            Ayakkabi.Malzeme = "Deri";

            //Console.WriteLine(ayakkabi1.Numara);

            //Console.WriteLine(Ayakkabi.Malzeme);

            ayakkabi1.Numara = 39;

            //Console.WriteLine(ayakkabi1.Numara);

            ayakkabi1.Marka = "Mavi Kundura";
            //Console.WriteLine(ayakkabi1.Marka);

            ayakkabi1.Fiyat = 150;
            //Console.WriteLine(ayakkabi1.Fiyat);

            ayakkabi1.IndirimUygula(0.30);
            //Console.WriteLine(ayakkabi1.Fiyat);

            Ayakkabi.Malzeme = "Süet";
            //Console.WriteLine(Ayakkabi.Malzeme);

            ayakkabi1.Tipi = AyakkabiTipi.Kundura;

            var ayakkabi2 = new Ayakkabi();
            ayakkabi2.Tipi = AyakkabiTipi.Spor;

            Console.WriteLine(ayakkabi1.Tipi);
            Console.WriteLine(ayakkabi2.Tipi);


            Console.ReadKey();
        }
    }
}
