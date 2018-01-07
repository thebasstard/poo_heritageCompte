using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Heritage_Compte
{
    class ComptePayant : Compte
    {
        private double operation;

        public double Operation
        {
            get { return operation; }
            set { operation = value; }
        }

        public ComptePayant() : base() { }

        public ComptePayant(int Solde) : base(Solde) { }

        public override void Deposer(double s)//méthode de la classe de base redéfinie 
        {
            base.Deposer(s);
            base.Retirer(5);
        }

        public override void Retirer(double s)//méthode de base redéfinie
        {
            base.Retirer(s);
            base.Retirer(5);
        }

        
    }
}
