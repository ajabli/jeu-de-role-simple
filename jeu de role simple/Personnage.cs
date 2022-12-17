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
        public string _Nom { get; set; }
        // coucou new test
        public int PointDeVie { get; set; }
        public int PointAttaque { get; set; }
        public int PointDefense { get; set; }

        public int Initiative { get; set; }

        public string Equipment { get; set; }

        public List<string> MonEquipment = new List<string>();
       


        public Personnage(string nom)
        {
            this.Nom = nom;
            this.MonEquipment = new List<string>();
            this.MonEquipment.Add(this.Equipment);
        }

        public virtual void AjouterEquipment(string arme)
        {
           
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
            Console.WriteLine("Point de vie : " + PointDeVie);
            Console.WriteLine("Point d'attaque : " + PointAttaque);
            Console.WriteLine("Point de defence : " + PointDefense);
            Console.WriteLine("Son Arme : " + Equipment);
            Console.WriteLine();
        }

       

    }
}
