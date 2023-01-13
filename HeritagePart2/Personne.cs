using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeritagePart2
{
    class Personne
    {
        private int code;
        private string nom;
        private string prenom;
        public Personne(int code,string nom,string prenom)
        {
            this.code = code;this.nom = nom;this.prenom = prenom;
        }
        public virtual string getInfos()
        {
            return "code " + code + " Nom : " + nom + " Prénom : " + prenom;
        }
        public override string ToString()
        {
            return "code " + code + " Nom : " + nom + " Prénom : " + prenom;
        }

        public override bool Equals(object obj)
        {
            Personne p = obj as Personne;
            if (this.code == p.code && this.nom == p.nom && this.prenom == p.prenom)
                return true;
            else
                return false;
           
        }



    }
}
