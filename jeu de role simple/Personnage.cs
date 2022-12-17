using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jeu_de_role_simple
{
    public abstract class Personnage
    {
        public string nom { get; set; }// majuscule pour prop!!!!!
        public int pointDeVie { get; set; }
        public int pointAttaque { get; set; }
        public int pointDefense { get; set; }

        public int initiative { get; set; }

        public string equipment { get; set; }

        public List<string> MonEquipment = new List<string>();
       


        public Personnage(string nom)
        {
            this.nom = nom;
            this.MonEquipment = new List<string>(); 
        }

        public virtual void AjouterEquipment(string arme)
        {
            //List<string> MonEquipment = new List<string>() { this.equipment };

            this.MonEquipment.Add(arme);
            Console.WriteLine("Liste de vos Armes après récupération :");
            foreach(string chose in this.MonEquipment)
            {
                Console.WriteLine("--"+chose);
            }
        }

        public virtual void ChangerEquipment()
        {
                       Console.WriteLine("Quelle Arme souhaitez vous recuperer pour le prochain combat");
            for(int i=0; i<this.MonEquipment.Count(); i++)
            {
                Console.WriteLine($"{i+1} : {this.MonEquipment[i]}");
            }
            int choix = int.Parse(Console.ReadLine());
            Console.WriteLine("Votre choix ", MonEquipment[choix-1]);
        }

        /*
        public virtual void MOntrerEquipment()
        {
            //List<string> MonEquipment = new List<string>() { this.equipment };

            Console.WriteLine("Quelle Arme souhaitez vous recuperer pour le prochain combat ? :");
            for (int i = 0; i < Monequipment.Count(); i++)
            {
                Console.WriteLine($"{i + 1} : {Monequipment}");
            }
            int choix = int.Parse(Console.ReadLine());
            Console.WriteLine("Votre choix ", this.equipment[choix - 1]);
        }
        */


        //Fonction qui permet d'attaquer adversaire et faire perdre point de vie
       

        public virtual void Afficher()
        {
            Console.WriteLine("Point de vie : " + pointDeVie);
            Console.WriteLine("Point d'attaque : " + pointAttaque);
            Console.WriteLine("Point de defence : " + pointDefense);
            Console.WriteLine("Son Arme : " + equipment);
            Console.WriteLine();
        }

       

    }
}
