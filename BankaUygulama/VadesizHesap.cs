using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaUygulama
{
    public class VadesizHesap : Hesap
    {
        public VadesizHesap(string hesapNo, double bakiye) : base(hesapNo, bakiye)
        {
        }

        public override double FaizOrani()
        {
            //vadesiz hesabın faiz oranı sıfır
            return 0.0;
        }


        public override void ParaCek(double tutar)
        {
            if (tutar <= Bakiye)
            {
                base.ParaCek(tutar); //temel para çekme fonksiyonu çağırılıyor
            }
            else
            {
                Console.WriteLine("Yetersiz bakiye");
            }
        }
    }
}
