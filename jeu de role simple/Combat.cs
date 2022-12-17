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
            this.Monstre.PointDeVie -= this.Personnage.PointAttaque;
         }

        public virtual void MonstreAttaquer()
        {
            this.Personnage.PointDeVie -= this.Monstre.PointAttaque;
        }

        public virtual void InfoCombat()
        {
            Console.WriteLine($"Vies du {this.Personnage.Nom} : {this.Personnage.PointDeVie}");
            Console.WriteLine(" Vie du Monstre :"+this.Monstre.PointDeVie);         


        }
       



    }
}
