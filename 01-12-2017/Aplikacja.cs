using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_12_2017
{
    class Aplikacja
    {
        private char klawisz;

        Koszyk temp = new Koszyk();

        public Aplikacja()
        {

        }

        ~Aplikacja()
        {

        }

        public char WczytajKlawisz()
        {
            Console.WriteLine("Legenda:");
            Console.WriteLine("p - dodaj produkt");
            Console.WriteLine("k - skopiuj ostatnio dodany produkt");
            Console.WriteLine("s - suma do zaplaty");
            Console.WriteLine("d - skasuj produkt");
            Console.WriteLine("w - wyswietl zawartosc");
            Console.WriteLine("x - wydrukuj paragon");
            Console.WriteLine("e - zakończ");
            klawisz = Console.ReadKey().KeyChar;
            Console.WriteLine("\nWybrano: {0}", klawisz);
            return klawisz;
        }

        public void WykonajDzialanie()
        {
            switch (klawisz)
            {
                case 'p': 
                case 'P':
                    Console.WriteLine("Podaj nazwe, cene jednostkowa i ilosc");
                    temp.Dodaj(Console.ReadLine(), Convert.ToDouble(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));

                    break;

                case 's':                
                case 'S':
                    Console.WriteLine("{0}", temp.Cena());
                    break;

                case 'k':
                case 'K':
                    Console.WriteLine("Zaplac 50$ aby odblokowac te funkcje");
                    break;

                case 'd':
                case 'D':
                    int nr;
                    Console.WriteLine("Podaj index produktu do usuniecia");
                    //Console.WriteLine("{0}", temp.Usun(0));
                    nr = Convert.ToInt32(Console.ReadLine());

                    if ((nr < 0) || (nr > temp.Ilosc())) Console.WriteLine("Nieprawidlowy index");
                    else temp.Usun(nr);
                    break;

                case 'w':
                case 'W':
                    temp.WyswietlZawartosc();
                    break;

                case 'x':
                case 'X':
                    temp.Paragon();
                    break;

                case 'e': 
                case 'E':
                    Console.WriteLine("Koniec");
                    break;

                default:
                    Console.WriteLine("Zly wybor");
                    break;
            }
        }

        public void DodajProdukt(string nazwa, double cena, int ilosc)
        {
            Console.WriteLine("{0}",nazwa);
        }
    }
}
