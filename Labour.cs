using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfValue
{
    internal abstract class Labour:IPrint
    {
        protected string code;
        protected string type;
        
        public Labour(string code, string type)
        {
            this.code = code;
            this.type = type;
        }

        public virtual void Print()
        {
            Console.WriteLine("Информация за дейността");
            Console.WriteLine($"Код : {code} Вид : {type}");
        }
    }
}
