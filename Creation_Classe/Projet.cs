using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creation_Classe
{
    class Projet
    {
        // Variables - Attributs
        private string _Titre;
        private string _Description;
        public Projet(string Titre)
        {
            this.Titre = Titre;
        }
        // Constructeur par défaut
        public Projet() {}

        // Propriété
        public string Titre
        {
            set
            {
                _Titre = value;
            }
            get
            {
                return _Titre;
            }
        }


        public override string ToString()
        {
            return "Projet : " + this._Titre;
        }

        public override bool Equals(object obj)
        {
           
            Projet projet2 = obj as Projet;
            if(projet2 == null)
            {
                return false;
            }
            return true;
        }
    }
}
