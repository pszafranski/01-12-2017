using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_12_2017
{
    class Program
    {
        static void Main(string[] args)
        {
            Aplikacja temp = new Aplikacja();
            char ch = 'p';

            Console.WriteLine("{0}",Convert.ToString(DateTime.Now.ToFileTime()));

            while (ch != 'e')
            {
                ch = temp.WczytajKlawisz();

                temp.WykonajDzialanie();
            }

            //Koszyk kappa = new Koszyk();

            //kappa.Dodaj("Kappa",2.50,1);

            //Console.WriteLine("{0}", kappa.Cena());
        }
    }
}
