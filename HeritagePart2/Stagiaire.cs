using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeritagePart2
{
    class Stagiaire : Personne
    {
        private char sexe;
        private string filiere;
        public Stagiaire(int  code ,string nom,string prenom, char sexe , string filiere )
             : base(code,nom,prenom)
        {
            this.sexe = sexe;
            this.filiere = filiere;
        }
        public override string getInfos()
        {
            return base.getInfos() + " sexe : " + sexe + " Filière : " + filiere;
        }

        public override string ToString()
        {
            return base.ToString() + " Sexe :"+sexe+ " Filiere :"+filiere;
        }

        public override bool Equals(object obj)
        {
            Stagiaire S = obj as Stagiaire;
            /*  if (base.Equals(S) == true && this.sexe == S.sexe && this.filiere == S.filiere)
                  return true;
              else
                  return false;*/

            return base.Equals(S) == true && this.sexe == S.sexe && this.filiere == S.filiere;
        }

    }
}
