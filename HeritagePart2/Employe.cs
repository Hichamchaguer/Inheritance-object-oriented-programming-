using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeritagePart2
{
    class Employe : Personne
    {
        private double salaire;
        public Employe(int code,string nom,string prenom,double salaire)
            :base(code,nom,prenom)
        {
            this.salaire = salaire;
        }
        //redéfinition de méthode
        public override string getInfos()
        {
            return base.getInfos() + " Salaire :"+salaire;
        }


        public override string ToString()
        {
            return base.ToString() + " Salaire : "+salaire;
        }
        public override bool Equals(object obj)
        {
          //  Employe E = (Employe)obj;
            Employe E = obj as Employe;

            return base.Equals(E) && (this.salaire == E.salaire);
        }
    }
}
