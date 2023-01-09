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
        public string Nom { get; set; }
        public int PointDeVie { get; set; }
        public int PointAttaque { get; set; }
        public int PointDefense { get; set; }

        public int Initiative { get; set; }

        public string Equipment { get; set; }

         


        public Personnage(string nom)
        {
            this.Nom = nom;
            this.Equipment = Equipment;     
        }

      
    

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
