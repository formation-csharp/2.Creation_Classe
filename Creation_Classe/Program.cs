using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creation_Classe
{
    class Program
    {
        static void Main(string[] args)
        {
            // Création d'un objet de type Projet 
            Projet projet1 = null;

            // Création de l'instance Projet
            projet1 = new Projet("Projet 1");

            // Utilisation de la propriété "Titre
            projet1.Titre = "Création d'une application";

            // Affichage de l'objet
            Console.WriteLine(projet1);
            Console.WriteLine(projet1.ToString());
            Console.WriteLine(projet1.Titre);

            // equals
            Projet projet2 = new Projet();
            projet2.Titre = "Création d'une application";

            if(projet1.Equals(projet2))
            {
                Console.WriteLine("Projet 1 égale Projet 2");
            }
            else
            {
                Console.WriteLine("Projet 1 n'égale pas Projet 2");
            }

           
          
            Console.ReadKey();
        }
    }
}
