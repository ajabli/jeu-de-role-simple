using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jeu_de_role_simple
{
    public class MortVivant : Personnage
    {
        public MortVivant(string nom) : base(nom)
        {
            this.nom = nom;
            pointDeVie = 100;
            pointAttaque = 5;
            pointDefense = 1;
            initiative = 15;
            equipment = "Couteau";
        }
    }

}
