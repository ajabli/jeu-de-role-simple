using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jeu_de_role_simple
{
    public class Menu
    {
        public void DebutJeux()
        {
            Console.WriteLine("Bonjour et bienvenu dans le jdr Pandora");
            Console.WriteLine();
            Console.WriteLine("1. Commencer à jouer");
            Console.WriteLine("3. Quitter");
            while (true)
            {
                try
                {
                    int choix = int.Parse(Console.ReadLine());
                    if (choix == 1)
                    {

                        break;
                    }
                    if (choix == 3)
                    {
                        Console.WriteLine("Au revoir.");
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.WriteLine("tu n'as pas mis un bon chiffre");
                    }
                }
                catch
                {
                    Console.WriteLine("on a dit un chiffre");
                }
            }
        }
    }
}
