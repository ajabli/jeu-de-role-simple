using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jeu_de_role_simple
{
    class Combat
    {
            
        public string Name { get; set; }
        public bool Encours { get; set; }

        public Personnage Personnage;
        public Monstre Monstre;

        public Combat(Personnage personnage, Monstre monstre)
        {
            this.Personnage = personnage;
            this.Monstre = monstre; 
            this.Encours = true;           
        }

        public void Attaquer()
        {  // si c'est le Héro qui attaque le Monstre
            this.Monstre.PointDeVie -= this.Personnage.PointAttaque;
         }

        public void MonstreAttaquer()
        {
            this.Personnage.PointDeVie -= this.Monstre.PointAttaque;
        }

        public void InfoCombat()
        {
            Console.WriteLine($"Vies du {this.Personnage.Nom} : {this.Personnage.PointDeVie}");
            Console.WriteLine(" Vie du Monstre :"+this.Monstre.PointDeVie);
            if (this.Monstre.PointAttaque > this.Personnage.PointAttaque)
            {
                Console.WriteLine($" Aie il semble que  {this.Monstre.Nom} a des attaques plus fortes que toi ");
            }
        }

        public  bool VerifierPerdant()
        {
            bool condition = false;
            if((this.Personnage.PointDeVie > this.Monstre.PointDeVie)&&(this.Monstre.PointDeVie <= 0))
            {
                return condition;
            }
               

            if(( this.Monstre.PointDeVie >this.Personnage.PointDeVie)&& (this.Personnage.PointDeVie <= 0))
            {
                return condition;
            }
            condition= true;
            return condition;            

        }




        public int ConfirmerJeu()
        {
            
            // If gère qquand le Hero Perd : 2 choix soit recommencer ou quitter Jeu
            if ((this.Monstre.PointDeVie > this.Personnage.PointDeVie) && (this.Personnage.PointDeVie <= 0))
            {
                Console.WriteLine($" -- GAME OVER-- ");
                Console.WriteLine($"tu as perdu contre {this.Monstre.Nom}");
                Console.WriteLine($"Tes points de Vies sont de {this.Personnage.PointDeVie} ");
                Console.WriteLine("");
                Console.WriteLine("Fais un choix : \n" +
                " "+
               "Appuye 1 SI Tu souhaites Recommencer le Jeu\n" +
               "Appuye 2 Si Tu souhaites Quitter le Jeu ");
                while (true)
                {
                    try
                    {
                        int choix = int.Parse(Console.ReadLine());
                        if (choix == 1)
                        {
                            return 1;//recommencer le jeu
                        }
                        if (choix == 2)
                        {
                            return 2;// Quitter le jeu
                        }                      
                    }
                    catch
                    {
                        Console.WriteLine(" Veuillez choisir soit (1) ou (2)");                   
                    }
                }
            }
            // if gère lorsque le Hero Gagne : affichage des armes-> voir fonction menu en programme
            if((this.Personnage.PointDeVie > this.Monstre.PointDeVie) && (this.Monstre.PointDeVie <= 0))
            {
                return 3;
            }
         return 0;
        }
    }
}
