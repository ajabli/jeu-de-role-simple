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
            this.Nom = nom;
            PointDeVie = 40;
            PointAttaque = 15;
            PointDefense = 1;
            Initiative = 15;
            Equipment = "Couteau";
        }
    }

}
