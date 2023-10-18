using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace upravljanjeGreskama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int godRod;
            bool kontrola = false;

            do
            {

                Console.Write("Upiši svoju godinu rođenja: ");

                try
                {
                    godRod = Convert.ToInt16(Console.ReadLine());
                    Console.Write("Rođen si " + godRod + " godine.");
                    kontrola = true;
                }

                catch (Exception greska)
                {

                    Console.WriteLine(greska.Message);
                    kontrola=false;

                }

            } while (kontrola == false);
            Console.ReadKey();

        }
    }
}
