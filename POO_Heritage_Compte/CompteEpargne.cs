using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Heritage_Compte
{
    class CompteEpargne : Compte
    {
        private double tauxInteret = 6;

        public double TauxInteret 
        {
            get { return tauxInteret; }
            set { tauxInteret = value; }
        }

        public CompteEpargne() : base() { } //constructeur par défaut

        public CompteEpargne(double solde) : base(solde) { } //constructeur d'initialisation
        
        public void CalculerInteret()
        {
             Deposer((Solde * tauxInteret) / 100);
        }

        public override string ToString()
        {
            return "Compte d'épargne : " + base.ToString() + ", taux d'intérêt : " + tauxInteret;
        }
    }
}
