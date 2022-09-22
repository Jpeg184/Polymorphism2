using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism2
{
    class Yonetici : Calisan
    {
        private double departmanKar;
        public double DepartmanKar
        {
            get { return departmanKar; }
            set { departmanKar = value; }
        }

        public override void ZamYap(double zamMiktar)
        {
           if(departmanKar > 50000)
            {
                zamMiktar += 6000;
            }
           base.ZamYap(zamMiktar);  
        }

    }
}
