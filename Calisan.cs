using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism2
{
   class Calisan
    {
        private string calisanAd;
        private double calisanMaas;
        public string CalisanAd
        {
            get { return calisanAd; }
            set { calisanAd = value; }
        }
        public double CalisanMaas
        {
            get { return calisanMaas; }
            set { calisanMaas = value; }
        }
        public virtual void ZamYap (double zamMiktar)
        { 
            calisanMaas += zamMiktar;
        }
        
    }
}
