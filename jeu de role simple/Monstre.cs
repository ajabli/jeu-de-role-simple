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
            this.nom = nom;
            pointDeVie = 80;
            pointAttaque = 7;
            pointDefense = 8;
            initiative = 15;
            equipment = "Marteau";

        }

    }
}
