using System;

namespace ConsoleApp53
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] Soz = { "Aysun", "Konul", "Mirsaleh" };
            char herf = 'n';
             FindString(Soz, herf);

        }
        static void FindString(string[] Soz, char herf)
        {
            foreach (var item in Soz)
            {
                if (item.Contains(herf))
                {
                    Console.WriteLine(item);
                }
               
            }return;

        }
    }
    }

