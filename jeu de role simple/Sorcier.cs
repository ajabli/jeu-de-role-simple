using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jeu_de_role_simple
{
    class Sorcier : Personnage
    {
        public Sorcier(string nom) : base(nom)
        {
            this.Nom = nom;
            PointDeVie = 70;
            PointAttaque = 10;
            PointDefense = 3;
            Initiative = 15;
            Equipment = "Baguette Magique";
           
        }
    }
}
