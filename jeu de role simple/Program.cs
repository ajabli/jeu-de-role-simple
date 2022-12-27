// See https://aka.ms/new-console-template for more information
using System;
using System.Linq;


namespace jeu_de_role_simple
{
    class Program
    {
        static void Presenter(Personnage personnage1, Personnage personnage2 )
        {
            List<string> list = new List<string>();
            list.Add( personnage1.Nom);
            list.Add( personnage2.Nom);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("**************************INFO du Combat ******************************");
            Console.WriteLine(list[0]+"  (TOI)         VS      "+list[1].ToString()+ "     (Adversaire)");
            Console.WriteLine("");
            Console.WriteLine(list[1].ToString()+ "   est Dangereux regarde sa fiche avant de le combattre" );
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.White;
            personnage2.Afficher();
        }


        public static Monstre ChargementMonstre( )
        {
            Random ran = new Random();
            int alea = ran.Next(1, 9); // TO DO : eviter la repetition 

            switch (alea)
            {
                case 1:
                    Monstre a = new Monstre("Dinosaure");// rajouter de deleter le choix a
                    return a;
                case 2:
                    Monstre b = new Monstre("Dinosaure2");
                    return b;
                case 3:
                    Monstre c = new Monstre("Dinosaure3");
                    return c;
                case 4:
                    Monstre d = new Monstre("Dinosaure4");
                    return d;
                case 5:
                    Monstre e = new Monstre("Dinosaure4");
                    return e;
                case 6:
                    Monstre f = new Monstre("Dinosaure5");
                    return f;
                case 7:
                    Monstre g = new Monstre("Dinosaure6");
                    return g;
                case 8:
                    Monstre h = new Monstre("Dinosaure7");
                    return h;
                default:
                    return null;
                    

            }
        }


        private static void Main(string[] args)
        {
            Console.WriteLine("aaaaaaaaoooiipppppeeeeiiuu");
            // Chargement des Heros et du Monstre + creation et chargement arme initiale Hero 
            List<string> listHero = new List<string>();
            Modele modele = new Modele();
            Personnage hero = modele.SelectionPersonnage();// selection de ton héro 
            listHero.Add(hero.Equipment);
            Console.WriteLine("arme du monstre " + hero.Equipment);
            Console.WriteLine("Liste arme au debut du jeu :");
            foreach (string s in listHero)
            {
                Console.WriteLine(s);
            }


            
            // Creer une fonction qui explique le combat et donne les infos principales avant 
            // de commencer            
            ///Combat n1 = new Combat(p, mo);
            //Array array1 = new Array()["n1"; "n2"];
            //Combat n2 = new Combat(p, mo);
            Console.WriteLine("testons les combats  ,,,,,,");            
            int compteur = 9;
            while (compteur > 0)
            {
                Console.WriteLine($"     ____________Combat numero {compteur}_______________");
                Monstre mon = ChargementMonstre();// chargement du Monstre par fonction aléa
                Presenter(hero, mon);
                Console.WriteLine(mon.Nom);
                Combat a = new Combat(hero, mon);
                //a.Encours = true;
                while (a.Encours==true)
                {
                    Console.WriteLine("");
                    if ((a.Encours = a.VerifierGagnant()) == false)
                        break;// verifie qui gagne la partie après attaque du Monstre
                    a.Attaquer();// Hero attaque monstre 
                    if ((a.Encours = a.VerifierGagnant()) == false)
                        break;// verifie qui gagne la partie
                    a.InfoCombat();
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine(" Le Monstre t'attaque maintenant !!!!!!!!!!");
                    Console.ForegroundColor = ConsoleColor.White;
                    a.MonstreAttaquer(); // Monstre attaque

                    a.InfoCombat();
                    Console.WriteLine(" Appiuie sur n'importe quelle touche pour continuer COMBAT");
                    Console.ReadKey();
                    Console.Clear();
                }
                Console.WriteLine("point de vie hero,"+hero.PointDeVie);
                Console.WriteLine("point de vie Monstre," + mon.PointDeVie);
                Console.ReadKey();

                // TO do recuperer les infos stats du combat X (gagné perdu) + recuperer l'arme
                // si le monstre gaggne; la partie est finie-> voulez vous rejpuer ou quitter le jeu
                //si hero, on continue la partie, (+ point du Monstre que je cumule ) + recuper les armes + affichage de la liste 

                compteur--;
             Console.WriteLine($" hors boucle   :{compteur} ");
             Console.WriteLine();


            }



            /*  
               Console.WriteLine($"Combat nr {10 - count + 1} : Appuie sur ENTER pour le suivant!!");
                listHero.Add(mo.Equipment);
               Console.WriteLine("Combat numero 1 fini ");
               foreach (string s in listHero)
               {
                   Console.WriteLine(s);
               }
               Console.WriteLine();
               // To DO fonction qui fait commencer le Hero qui sera le joueur principale pour toutes les arenes

               Console.WriteLine("_____________________________________________");
           }
          */

        }

    }
}
