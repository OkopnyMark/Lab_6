using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryamougo
{
    class pryamoug
    {
        public double shir;
        public double dlin;
        public pryamoug(double dlin, double shir)
        {
            this.dlin = dlin;
            this.shir = shir;
        }

        public override string ToString()
        {
            return base.ToString() + "\n" + "����� ��������������: " + dlin + "\n" + "������ ��������������: " + shir + "\n" + "������� ��������������: " + shir * dlin + "\n";
        }


        public void print()
        { Console.WriteLine(this.ToString()); }

    }

}
