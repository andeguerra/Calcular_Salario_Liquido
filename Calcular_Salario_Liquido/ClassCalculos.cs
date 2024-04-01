using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcular_Salario_Liquido
{
    internal class ClassCalculos
    {
        public string nome;
        public double slb;
        public double outros_desc;
        public double dep;
        public double inss;
        public double irrf;
        public double sll;

        public ClassCalculos(string n, double sb, double outros, double d, double i, double ir, double sl) 
        {
            nome = n;
            slb = sb;
            outros_desc = outros;
            dep = d;
            inss = i;
            irrf = ir;
            sll = sl;
        }
    }
}
