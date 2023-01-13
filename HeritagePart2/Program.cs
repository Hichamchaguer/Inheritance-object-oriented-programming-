using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeritagePart2
{
    class Program
    {
        static void Main(string[] args)
        {
            Stagiaire S1 = new Stagiaire(10, "idrissi", "karim", 'M', "TDI");
            Personne p1 = new Personne(100, "alaoui", "brahim");
            Employe E1 = new Employe(1000, "chaabi", "walid", 9000);
            Employe E2 = new Employe(1000, "chaabi", "walid", 8000);
            Stagiaire S2 = new Stagiaire(10, "idrissi", "karim", 'M', "TDI");


            Console.WriteLine(S1.getInfos());
            Console.WriteLine(p1.getInfos());
            Console.WriteLine(E1.getInfos());


            int a = 9,b=10;
            string ch1 = a.ToString();
            string ch2 = b.ToString();
            Console.WriteLine(ch1 + ch2);

            Console.WriteLine(p1.ToString());
            Console.WriteLine(S1.ToString());
            Console.WriteLine(E1.ToString());

            int e =10,f=10;
            if( e.Equals(f) == true)
            {
                Console.WriteLine("égaux");
            }
            else
            {
                Console.WriteLine("ne sont pas égaux");
            }

            Personne p2 = new Personne(1001, "chaguer", "hicham");
            Personne p3 = new Personne(1001, "name1", "name1_");
            Console.WriteLine(p2.Equals(p3));
            Console.WriteLine("stagiaire : " + S1.Equals(S2));
            Console.WriteLine("Employe : " + E1.Equals(E2));





            Console.ReadKey();
        }
    }
}
