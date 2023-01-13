using System;
using System.Linq;


namespace jeu_de_role_simple
{
    class Program
    {
        static void Presenter(Personnage personnage1, Personnage personnage2)
        {
            Console.Clear();
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
            Console.WriteLine();
            Console.WriteLine(personnage1.Nom);
            personnage1.Afficher();
        }


        
        public static Monstre ChargementMonstre()
        {
            Random ran = new Random();
            int alea = ran.Next(1, 9);  

            switch (alea)
            {
                case 1:
                    Monstre a = new Monstre("Voldetesmorts");
                    return a;
                case 2:
                    Monstre b = new Monstre("Plancton le magnifique");
                    return b;
                case 3:
                    Monstre c = new Monstre("le voisin");
                    return c;
                case 4:
                    Monstre d = new Monstre("Ilère en Colère");
                    return d;
                case 5:
                    Monstre e = new Monstre("Blop Infamélique");
                    return e;
                case 6:
                    Monstre f = new Monstre("Uncle Sam");
                    return f;
                case 7:
                    Monstre g = new Monstre("Thanatos");
                    return g;
                case 8:
                    Monstre h = new Monstre("le boss des internets");
                    return h;
                default:
                    return null;

            }
        }


        private static void Main(string[] args)
        {
            Console.WriteLine("******** BIENVENUE AU JEU DE ROLE **********");
            Console.WriteLine();
            //test ahmed
            // Chargement des Heros et du Monstre + creation et chargement arme initiale Hero 
            List<string> listHero = new List<string>();// chargement liste Hero
            Modele modele = new Modele();
            Personnage hero = modele.SelectionPersonnage();// selection de ton héro 
            listHero.Add(hero.Equipment);
             // Creer une fonction qui explique le combat et donne les infos principales avant 
            // de commencer
            int choix=0;
            int compteur = 0;
            while (true & choix!=2)
            {
                if (compteur == 10)
                {
                    Console.Clear();
                    Console.WriteLine(" bravo tu as gagné veux tu rejouer ? ");
                    Console.WriteLine();
                    Console.WriteLine(" Appuye sur 1 pour rejouer ou sur 2 pour quitter");

                    while (true)
                    {
                        try
                        {
                            int rejouer = int.Parse(Console.ReadLine());
                            if (rejouer == 1)
                            {
                                Console.Clear();
                                hero = modele.SelectionPersonnage();
                                listHero.Add(hero.Equipment);
                                choix = 0;
                                compteur = 0;
                                break;
                            }
                            else if (rejouer == 2)
                            {
                                Console.WriteLine("Au revoir.");
                                Environment.Exit(0);
                            }
                        }
                        catch
                        {
                            Console.WriteLine(" Veuillez choisir soit (1) ou (2)");
                        }
                    }
                }
                Console.WriteLine($"___________________ Combat numero {compteur+1} ____________________");
                modele.ScenarioInfo(compteur);
                Monstre mon = ChargementMonstre();// chargement du Monstre par fonction aléa
                Presenter(hero, mon);
                Combat a = new Combat(hero, mon);
                a.Encours = true;
                bool jeu = true;

                while (compteur < 10 && jeu==true)
                {
                    while (a.Encours == true)
                    {
                        if ((a.Encours = a.VerifierPerdant()) == false)
                            break;// verifie qui gagne la partie après attaque du Monstre
                        Console.WriteLine("Appuie sur n'importe quelle touche pour attaquer l'ennemi!!");
                        Console.ReadKey();
                        a.Attaquer();// Hero attaque monstre 
                        //modele.EcrireRalenti("L'attaque est lancée , j'espère que cela terrasera le monstre... ");
                     
                        if ((a.Encours = a.VerifierPerdant()) == false)
                            break;// verifie qui gagne la partie
                        modele.EcrireRalenti("Regardons maintenant les degats de l'attaque (ENTER pour continuer.. )");
                        a.InfoCombat();
                        Console.ReadKey();
                        Console.WriteLine();
                        Console.Clear();
                        

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
                        compteur = 9; // je reviens vers la 1ere boucle while pour rejouer 
                        hero = modele.SelectionPersonnage();// initialisation Hero et choix nouvel hero
                        jeu = false;
                        Console.Clear();
                    }
                    else if (choix == 2)
                    {
                        break;// on quitte le jeu
                    }
                    else if (choix == 3)// on reste dans la boucle principale pour continuer de jouer
                    {
                        ////info armes
                        Console.WriteLine($" Bravo tu as gagné le combat numero {compteur+1} avec  ton {hero.Equipment} ");
                        Console.WriteLine($"Tu as tué {mon.Nom} ! ");
                        Console.WriteLine($"Tu as aussi récupéré  l'arme  de {mon.Nom} ! ");
                        Console.WriteLine(mon.Equipment);
                        listHero.Add(mon.Equipment);// je rajoute l'arme du monstre vaincu dans ma liste
                        a.ProposerArmes(listHero);
                        jeu = false;            
                        modele.EcrireRalenti(" Maintenant prépare toi pour le prochain combat!!!!!!");
                    }

                    Random rand = new Random();
                    int BaumeDeSoin = rand.Next(1, 3);
                    if (BaumeDeSoin == 2)
                    {
                        Console.WriteLine("Oh tu a trouvé un baume de soin ");
                        Console.WriteLine("tes points de vies sont augmenté de 50");
                        Thread.Sleep(2000);
                        hero.PointDeVie = hero.PointDeVie + 50;
                        hero.Afficher();

                    }
                    compteur++;
 
                }

            }
        }
    }
}

