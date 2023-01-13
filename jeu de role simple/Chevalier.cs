using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jeu_de_role_simple
{
    class Chevalier : Personnage
    {       

        public Chevalier(string nom) : base(nom)
        {
            this.Nom = nom;
            PointDeVie = 100;
            PointAttaque = 7;
            PointDefense = 8;
            Initiative = 15;
            Equipment = "epee";
            
        }
        public override void Afficher()
        {
            
            base.Afficher();
        }


    }
}
