using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jeu_de_role_simple
{
    public class Modele
    {
                
        public Personnage SelectionPersonnage()
        {
            Console.WriteLine("choisi ton personnage : \n" +
               "Appuye 1 pour le chevalier\n" +
               "Appuye 2 pour le sorcier\n" +
               "Appuye 3 pour le mort vivant ");
            while (true)
            {
                try
                {
                    int choix = int.Parse(Console.ReadLine());
                    if (choix == 1)
                    {
                        Chevalier a = new Chevalier("Chevalier Lancelot");
                        return a;// choix du chevalier                       
                    }
                    if (choix == 2)
                    {
                        Sorcier s = new Sorcier("Roi Merlin");
                        return s;// choix sorcier                       
                    }
                    if (choix == 3)
                    {
                        MortVivant m = new MortVivant("Zombiz");
                        return m;

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



        public void ScenarioInfo(int compteur)
        {
            switch (compteur)
            {
                case 9:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine();
                    Console.WriteLine("     Le combat aura lieu dans la foret     ");
                    break;
                case 8:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine();
                    Console.WriteLine("     Le combat aura lieu en face de la mer     ");
                    break;
                case 7:
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("     Le combat aura lieu au Bord du Lac ");
                    break;
                case 6:
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine();
                    Console.WriteLine("Le combat aura lieu dans le desert ");
                    break;
                case 5:
                    Console.WriteLine();
                    Console.WriteLine("Le combat aura lieu sur la montagne");
                    break;
                case 4:
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine();
                    Console.WriteLine("Le combat aura lieu sur la plaine");
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine();
                    Console.WriteLine("Le combat aura lieu en ville");
                    break;
                case 2:
                    Console.WriteLine();
                    Console.WriteLine("Le combat aura lieu dans la jungle");
                    break;
                    
                case 1:
                    Console.WriteLine();
                    Console.WriteLine("Le combat aura lieu sur une ile");
                    break;

            }

            Console.WriteLine();
        }

        public void EcrireRalenti(string phrase)
     {
            
            foreach (var character in phrase)
            {
                Console.Write(character);
                Thread.Sleep(0);
            }
            Console.WriteLine();
            Console.ReadLine();
     }



    }

}