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

        public virtual void Attaquer()
        {  // si c'est le Héro qui attaque le Monstre
            this.Monstre.pointDeVie -= this.Personnage.pointAttaque;
         }

        public virtual void MonstreAttaquer()
        {
            this.Personnage.pointDeVie -= this.Monstre.pointAttaque;
        }

        public virtual void InfoCombat()
        {
            Console.WriteLine($"Vies du {this.Personnage.nom} : {this.Personnage.pointDeVie}");
            Console.WriteLine(" Vie du Monstre :"+this.Monstre.pointDeVie);         


        }
       



    }
}
