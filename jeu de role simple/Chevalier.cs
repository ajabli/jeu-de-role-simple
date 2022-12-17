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
            this.nom = nom;
            pointDeVie = 80;
            pointAttaque = 7;
            pointDefense = 8;
            initiative = 15;
            equipment = "epee";// ajouter equipement dans la fonction 
            
        }
        public override void Afficher()
        {
            //Console.WriteLine("classe :" + classe);
            base.Afficher();

        }

        public override void AjouterEquipment(string arme)
        {
            base.AjouterEquipment(arme);
        }

    }
}
