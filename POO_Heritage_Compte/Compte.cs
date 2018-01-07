using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Heritage_Compte
{
    class Compte
    {
        private int code;
        private double solde;
        private static int incr_Compte;

        public int Code
        {
            get { return code; }
            set { code = value; }
        }

        public double Solde
        {
            get { return solde; }
            set { solde = value; }
        }
        public int Incr_Compte
        {
            get { return incr_Compte; }
            set { incr_Compte = value; }
        }

        public Compte()
        {
            incr_Compte++;
            Code = incr_Compte;
        }

        public Compte(double s)
        {
            incr_Compte++;
            Code = incr_Compte;
            solde = s;
        }

        public virtual void Deposer(double s)//méthode virtuelle qui peut être modifiée dans une classe dérivée 
        {
            solde = solde + s;
        }

        public virtual void Retirer(double s)//méthode virtuelle qui peut être modifiée dans une classe dérivée
        {
            solde = solde - s;
        }

        public override string ToString()
        {
            return "Code : " + code + ", solde = " + solde;
        }
    }
}
