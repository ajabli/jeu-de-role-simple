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
            this.nom = nom;
            pointDeVie = 45;
            pointAttaque = 10;
            pointDefense = 3;
            initiative = 15;
            equipment = "Baguette Magique";
           
        }
    }
}
