using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaUygulama
{
    public class KrediHesabi : Hesap
    {
        private double krediLimit;
        public KrediHesabi(string hesapNo, double bakiye,double krediLimit) : base(hesapNo, bakiye)
        {
            this.krediLimit = krediLimit;
        }

        public override double FaizOrani()
        {
            return 20.0;
        }

        public override void ParaCek(double tutar)
        {
            if(tutar <= (Bakiye + krediLimit))
            {
                base.ParaCek(tutar);  //temel paraCek fonksyonu çağrılıyor
            }
            else
            {
                Console.WriteLine("Kredi limiti aşılmıştır");
            }
            
        }

        public void KrediLimitiGoruntule()
        {
            Console.WriteLine("Kredi limitiniz : " + krediLimit);
        }

    }
}
