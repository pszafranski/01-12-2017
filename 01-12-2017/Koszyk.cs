using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace _01_12_2017
{
    class Koszyk
    {
        private List<Produkt> zakupy = new List<Produkt>();

        public Koszyk()
        {

        }

        public Koszyk(string nazwa, double cena, int ilosc)
        {
            zakupy.Add(new Produkt(nazwa, cena, ilosc));
        }

        ~Koszyk()
        {

        }

        public void Dodaj(string nazwa, double cena, int ilosc)
        {
            zakupy.Add(new Produkt(nazwa,cena,ilosc));
        }

        public double Cena()
        {
            double temp = 0;
            foreach (var lista in zakupy)
            {
                temp += lista.cenaJednostkowa * lista.ilosc;
            }

            return temp;
        }

        public void WyswietlZawartosc()
        {
            foreach (var lista in zakupy)
            {
                Console.WriteLine("Produkt: {0} Cena: {1} Ilosc: {2} Lacznie: {3} ", lista.nazwa, lista.cenaJednostkowa, lista.ilosc, lista.cenaJednostkowa * lista.ilosc);
            }
        }

        public void Usun(int index)
        {
            zakupy.RemoveAt(index);
            Console.WriteLine("Usunieto produkt o indexie {0}",index);
        }

        public int Ilosc()
        {
            return zakupy.Count();
        }

        public void Paragon()
        {
            string sciezka = @"d:\\" + Convert.ToString(DateTime.Now.ToFileTime()) + ".txt";
            string pozycja;
            
            foreach (var lista in zakupy)
            {
                pozycja = lista.nazwa + " " + lista.cenaJednostkowa + "zl x " + lista.ilosc + " = " + lista.cenaJednostkowa * lista.ilosc + Environment.NewLine;
                File.AppendAllText(sciezka,pozycja);
            }
            
        }
    }
}
