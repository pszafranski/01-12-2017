using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_12_2017
{
    class Produkt : ICloneable
    {
        public string nazwa;
        public int ilosc;
        public double cenaJednostkowa;

        public Produkt()
        {

        }

        public Produkt(string nazwa, double cenaJednostkowa, int ilosc)
        {
            this.nazwa = nazwa;
            this.cenaJednostkowa = cenaJednostkowa;
            this.ilosc = ilosc;
        }

        ~Produkt()
        {

        }

        public object Clone()
        {
            throw new NotImplementedException();
        }
    }
}
