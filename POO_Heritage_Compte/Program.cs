using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Heritage_Compte
{
    class Program
    {
        static void Main(string[] args)
        {
            Compte C1 = new Compte();
            CompteEpargne C2 = new CompteEpargne();
            ComptePayant C3 = new ComptePayant();

            C1.Deposer(1000);
            C2.Deposer(1500);
            C3.Deposer(500);
            C1.Retirer(20);

            C2.CalculerInteret();

            Console.Out.WriteLine(C1);
            Console.Out.WriteLine(C2);
            Console.Out.WriteLine(C3);

            Console.ReadKey();
        }
    }
}
