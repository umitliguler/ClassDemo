using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemo
{
    class Ayakkabi
    {
        public AyakkabiTipi Tipi { get; set; }
        public static string Malzeme;
        public Ayakkabi()
        {
            Console.WriteLine("Ayakkabı nesnesi oluşturuldu");
        }

        ~Ayakkabi()
        {
            Console.WriteLine("Ayakkabı nesnesi bellekten atıldı.");
        }

        public Ayakkabi(string marka)
        {
            Marka = marka;
        }
        public double Fiyat { get; set; }

        public void IndirimUygula(double indirimOrani)
        {
            Fiyat = Fiyat - (Fiyat * indirimOrani);
        }

        private int _numara;

        public int Numara
        {
            get { return _numara; }
            set
            {
                if (value > 0)
                {
                    _numara = value;
                    Marka = "";
                }
                else
                {
                    _numara = 0;
                }
            }
        }

        public string Marka { get; set; }

    }
}
