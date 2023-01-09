using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jeu_de_role_simple
{
    class Monstre : Personnage
    {
        // monstre -> liste de 18 monstres ( Nom,pv,ini,point d'attaque,point de déffance)

        public Monstre(string nom) : base(nom)
        {
            Nom = nom;
            PointDeVie = 80;
            PointAttaque = 8;
            PointDefense = 8;
            Initiative = 15;
            Equipment = "Marteau";

        }

    }
}
