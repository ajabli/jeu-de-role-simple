﻿using System;
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
            PointDeVie = 80;
            PointAttaque = 7;
            PointDefense = 8;
            Initiative = 15;
            Equipment = "epee";// ajouter equipement dans la fonction 
            
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
