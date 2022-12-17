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
            Console.WriteLine("> "+personnage.Nom +" <");
            Console.ForegroundColor= ConsoleColor.White;
            personnage.Afficher();
        }

        public static Personnage SelectionPersonnage()
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
                        //break;
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
            Console.WriteLine("hhhh");

            // Chargement des Heros et du Monstre                                
            Monstre mo = new Monstre("Dragon");
            Personnage p = SelectionPersonnage();
            /*
            Jouer(p);
            //TO DO MENU : start Game+selectionPersonnage qui serz dans Combat
            Jouer(mo);
            // Creer une fonction qui explique le combat et donne les infos principales avant 
            // de commencer            
            Combat n1 = new Combat(p, mo);
            int count = 10;
            
            while (count>0 & n1.Personnage.PointDeVie>=0)
            {  
                Console.WriteLine($"Tu as choisi {p.Nom} comme Héro ");   
                Console.WriteLine($"Attaque numero {9-count+1} : Appuie sur ENTER pour le suivant!!");
                n1.Attaquer();// Hero attaque monstre seulment > continuer la fonction
                n1.InfoCombat();
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(" Le Monstre t'attaque et bien dans tes Dents!!!!!!!!!!!");
                Console.ForegroundColor = ConsoleColor.White;
                n1.MonstreAttaquer(); // Monstre attaque
                n1.InfoCombat();               
                Console.WriteLine("");
                Console.ReadKey();
                Console.Clear();
                // test des armes
                Console.WriteLine(" Testons les armes ajouts et listing ");
                count--;
                //n1.Encours = false;// propriété qui stoppera le combat > prevoir un check avec les vies
            }
            p.AjouterEquipment(mo.Equipment);
            */
            // prendre l'arme du Monstre si je gagne
            //string ArmeGagnée = mo.equipment;                   
            Console.WriteLine();
                // To DO fonction qui fait commencer le Hero qui sera le joueur principale pour toutes les arenes
               // Mettre le personnage choisi dans la boucle pour combattre son premier combat                                           
            Console.WriteLine("_____rrrrrrrrrrrrrr________________________");
           
        }        }
   
    }
