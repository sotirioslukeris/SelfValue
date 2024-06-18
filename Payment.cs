using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace SelfValue
{
    internal class Payment:Labour
    {
        private int chasove;
        private double chasovoZaplashtane;

        public Payment(string code, string type,int chasove, double chasovoZaplashtane):base(code,type)
        {
            this.chasove = chasove;
            this.chasovoZaplashtane = chasovoZaplashtane;
        }

        public int Chasove
        {
            get { return chasove; }
            set { chasove = value; }
        }

        public double ChasovoZaplashtane
        {
            get { return chasovoZaplashtane; }
            set { chasovoZaplashtane = value; }
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine("Заплащане : ");
            Console.WriteLine($"Часове : {chasove} Часово заплащане : {chasovoZaplashtane}");
        }

    }
}
