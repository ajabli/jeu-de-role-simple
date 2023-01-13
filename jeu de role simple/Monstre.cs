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
            var random = new Random();
            PointDeVie = random.Next(40, 91);
            PointAttaque = random.Next(4, 11);
            PointDefense = random.Next(4, 11);
            Initiative = 15;
            Equipment = "Marteau";

        }

    }
}
