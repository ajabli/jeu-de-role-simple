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

    public void EcrireRalenti(string phrase)
     {
            
            foreach (var character in phrase)
            {
                Console.Write(character);
                Thread.Sleep(60);
            }
            Console.WriteLine();
            Console.ReadLine();
     }



    }

}