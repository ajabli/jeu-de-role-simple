// See https://aka.ms/new-console-template for more information
using System;
using System.Linq;

namespace jeu_de_role_simple
{
    class Program
    {
        static void Jouer(Personnage personnage)
        {
            Console.ForegroundColor= ConsoleColor.Yellow;
            Console.WriteLine("> "+personnage.nom +" <");
            Console.ForegroundColor= ConsoleColor.White;
            personnage.Afficher();
        }

        public static string SelectionPersonnage()
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
                        return "a";// choix du chevalier
                        break;
                    }
                    if (choix == 2)
                    {
                        return "b";// choix soircier
                        break;
                    }
                    if (choix == 3)
                    {
                        return "c";
                        break;
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

        private static void Main(string[] args)
        {
            // Chargement des Heros et du Monstre 
            Chevalier a = new Chevalier("Chevalier Lancelot");
            
            Sorcier s = new Sorcier("Roi Merlin");
            MortVivant m = new MortVivant("Zombiz");
            Monstre mo = new Monstre("Dragon");
            Jouer(a);
            Jouer(s);
            Jouer(m);
            Jouer(mo);
            // Creer une fonction qui explique le combat et donne les infos principales avant 
            // de commencer

            // TO do inclure la fonction selectionPersonnage -> qui joue?
            object o =SelectionPersonnage();

            Combat n1 = new Combat(a, mo);
            
            Combat n2 = new Combat(a, mo);// je teste une evntuelle automatisation pour geerer plusieurs combats


            int count = 10;
            // boucle pour boucler sur les 9 combats (tant que?)
            while (count>0 & n1.Encours)
            {  
                Console.WriteLine("Combats du Chevalier ");                
                n1.Attaquer();// Hero attaque monstre seulment > continuer la fonction
                n1.InfoCombat();
                //prevoir affichage visuel
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(" Le Monstre t'attaque et bien dans tes Dents!!!!!!!!!!!");
                Console.ForegroundColor = ConsoleColor.White;
                n1.MonstreAttaquer(); // Monstre attaque
                n1.InfoCombat();
               
                Console.WriteLine("");
                Console.WriteLine($"Attaque numero {count-9} : Appuie sur ENTER pour le suivant!!");
                Console.ReadKey();
                Console.Clear();

                count--;
                //n1.Encours = false;// propriété qui stoppera le combat > prevoir un check avec les vies
            }
           

            // prendre l'arme du Monstre si je gagne
            string ArmeGagnée = mo.equipment;
            a.AjouterEquipment(ArmeGagnée);
            s.AjouterEquipment(ArmeGagnée);
            //a.MOntrerEquipment();
            Console.WriteLine();


            string choix = SelectionPersonnage();
            // To DO fonction qui fait commencer le Hero qui sera le joueur principale pour toutes les arenes
            // While() -> 9 parties
            Console.WriteLine("Ton choix est :" + choix);

            // Mettre le personnage choisi dans la boucle pour combattre son premier combat                                           
            Console.WriteLine("_______________________________________");
           
        }        }
   
    }
