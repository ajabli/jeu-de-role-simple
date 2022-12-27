using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jeu_de_role_simple
{
    public abstract class Personnage
    {
        public string Nom { get; set; }
        public int PointDeVie { get; set; }
        public int PointAttaque { get; set; }
        public int PointDefense { get; set; }

        public int Initiative { get; set; }

        public string Equipment { get; set; }

        public List<string> MonEquipment = new List<string>();
       


        public Personnage(string nom)
        {
            this.Nom = nom;
            this.Equipment = Equipment;     
            this.MonEquipment.Add(this.Equipment);
        }

        public  void AjoutEquipment(List<string>MonEquipment, string arme)
        {
            
            MonEquipment.Add(arme);
        }
     

        public virtual void ChangerEquipment()
        {
                       Console.WriteLine("Quelle Arme souhaitez vous recuperer pour le prochain combat");
            for(int i=0; i<this.MonEquipment.Count(); i++)
            {
                Console.WriteLine($"{i} : {this.MonEquipment[i]}");
            }
            int choix = int.Parse(Console.ReadLine());
            Console.WriteLine("Votre choix ", MonEquipment[choix-1]);
        }



        public virtual void AfficherEquipment()
        {
            
            int count = 28;
            for (int i = 0; i < count; i++)
                Console.Write("*");

            Console.WriteLine();

            for (int i = 0; i < (count / 4); i++)
            {
                if (i == 0)
                {
                    Console.WriteLine("* VOICI TES ARMES :        *");
                }
                Console.WriteLine($"*                          *");
                if (i == 2)
                {
                    Console.WriteLine($"*{this.Nom}:  {this.Equipment}     ");
                    Console.WriteLine($"*{this.Nom}:  {this.Nom}     ");
                    Console.WriteLine($"*{this.Nom}:  {this.Nom}      ");
                    Console.WriteLine($"*{this.Nom}: {this.Nom}      ");
                }
            }
            for (int i = 0; i < count; i++)
                Console.Write("*");
        }

        


        public virtual void Afficher()
        {
            Console.WriteLine("Point de vie : " + PointDeVie);
            Console.WriteLine("Point d'attaque : " + PointAttaque);
            Console.WriteLine("Point de defence : " + PointDefense);
            Console.WriteLine("Son Arme : " + Equipment);
            Console.WriteLine();
        }

       

    }
}
