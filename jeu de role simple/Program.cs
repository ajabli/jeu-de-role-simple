// See https://aka.ms/new-console-template for more information
using System;
using System.Linq;


namespace jeu_de_role_simple
{
    class Program
    {
        static void Presenter(Personnage personnage1, Personnage personnage2)
        {
            List<string> list = new List<string>();
            list.Add(personnage1.Nom);
            list.Add(personnage2.Nom);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("**************************INFO du Combat ******************************");
            Console.WriteLine(list[0] + "  (TOI)         VS      " + list[1].ToString() + "     (Adversaire)");
            Console.WriteLine("");
            Console.WriteLine(list[1].ToString() + "   est Dangereux regarde sa fiche avant de le combattre");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.White;
            personnage2.Afficher();
        }


        
        public static Monstre ChargementMonstre()
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
            Menu monMenu = new Menu();
            monMenu.DebutJeux();
            Console.Clear();
            // Chargement des Heros et du Monstre + creation et chargement arme initiale Hero 
            List<string> listHero = new List<string>();
            Modele modele = new Modele();
            Personnage hero = modele.SelectionPersonnage();// selection de ton héro 
            listHero.Add(hero.Equipment);
             // Creer une fonction qui explique le combat et donne les infos principales avant 
            // de commencer
            int choix=0;
            int compteur = 1;
            while (true & choix!=2)
            {   
                Console.WriteLine($"___________________ Combat numero {compteur} ____________________");
                modele.ScenarioInfo(compteur);
                Monstre mon = ChargementMonstre();// chargement du Monstre par fonction aléa
                Presenter(hero, mon);
                Console.WriteLine("Rajouter ici le terrain !!!!! ");
                // TO DO : presenter terrain initial: hero rencontre Monstre en visu avec emplacement
                Combat a = new Combat(hero, mon);
                a.Encours = true;
                bool jeu = true;
                if (compteur == 1)
                {   Console.WriteLine(" bravo tu as gagné veux tu rejouer ? ");
                    Console.WriteLine(" 1 pour rejouer et 2 pour quitter");
                    
                    while (true)
                    {
                        try
                        {int rejouer = int.Parse(Console.ReadLine());
                             if (rejouer == 1)
                                {
                                    hero = modele.SelectionPersonnage();
                                    listHero.Add(hero.Equipment);
                                    choix = 0;
                                    compteur = 9;
                                break;
                                }
                            else if (rejouer == 2)
                                {
                                    Console.WriteLine("Au revoir.");
                                    Environment.Exit(0);
                                }
                        }catch
                        {
                            Console.WriteLine(" Veuillez choisir soit (1) ou (2)");
                        }
                    }
                    
                   

                }
                while (compteur < 10 && jeu==true)
                {
                    while (a.Encours == true)
                    {
                        if ((a.Encours = a.VerifierPerdant()) == false)
                            break;// verifie qui gagne la partie après attaque du Monstre
                        Console.WriteLine(" Appuie sur n'importe quelle touche pour attaquer l'ennemi!!");
                        Console.ReadKey();
                        a.Attaquer();// Hero attaque monstre 
                        modele.EcrireRalenti("L'attaque est lancée , j'espère que cela terrasera le monstre... ");
                     
                        if ((a.Encours = a.VerifierPerdant()) == false)
                            break;// verifie qui gagne la partie
                        modele.EcrireRalenti("Regardons maintenant les degats de l'attaque (ENTER pour continuer.. ");
                        a.InfoCombat();
                        Console.ReadKey();
                        Console.WriteLine();
                        Console.Clear();
                        Console.WriteLine("Réafficher ici le terrain avec situation à jour ");

                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        //modele.EcrireRalenti(" Le Monstre t'attaque maintenant !!!!!!!!!!");
                        Console.ForegroundColor = ConsoleColor.White;
                        a.MonstreAttaquer(); // Monstre attaque
                        a.InfoCombat();
                        Console.ReadKey();   
                        
                    }
                    Console.ReadKey();
                    Console.WriteLine();
                    choix = a.ConfirmerJeu();
                    Console.Clear();
                    if (choix == 1)
                    {
                        a.Encours = true;
                        compteur = 0; // je reviens vers la 1ere boucle while pour rejouer 
                        hero = modele.SelectionPersonnage();// initialisation Hero et choix nouvel hero
                        jeu = false;
                        Console.Clear();
                    }
                    else if (choix == 2)
                    {
                        break;// on quitte le jeu
                    }
                    else if (choix == 3)
                    {
                        ////info armes
                        Console.WriteLine($" Bravo tu as gagné le combat numero {9-compteur+1} avec  ton {hero.Equipment} ");
                        Console.WriteLine($"Tu as tué {mon.Nom} ! ");
                        Console.WriteLine($"Tu as aussi récupéré  l'arme  de {mon.Nom} ! ");
                        Console.WriteLine(mon.Equipment);
                        listHero.Add(mon.Equipment);

                        Console.WriteLine("aperçu equipement : ");
                        foreach(string arme in listHero)
                        {
                            Console.WriteLine(arme);
                        }
                        //prevoir menu choix changement arme
                        hero.Equipment = mon.Equipment;
                        //hero.ChangerEquipment();
                        jeu = false;            
                        
                        ////modele.EcrireRalenti(" Maintenant prépare toi pour le prochain combat!!!!!!");
                    }
                    
                    compteur++;
 
                }

            }
        }
    }
}

