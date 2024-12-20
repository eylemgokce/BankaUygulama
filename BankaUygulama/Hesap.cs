using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaUygulama
{
    public abstract class Hesap
    {
        private string hesapNo;
        private double bakiye;

        protected Hesap(string hesapNo,double bakiye)
        {
            this.hesapNo = hesapNo;
            this.bakiye = bakiye;
        }

        public string HesapNo {
            get
            {
                return hesapNo;
            }
            set
            {
                value = hesapNo;
            } 
        
        }

        public double Bakiye {
            get
            {
                return bakiye;
            }
            set
            {
                value = bakiye;
            }

        }


        public abstract double FaizOrani();

        public void ParaYatir(double tutar)
        {
            if (tutar > 0)
            {
                bakiye += tutar;
                Console.WriteLine(tutar + " Tl hesabınıza yatırıldı. Yeni bakiye : " + bakiye);
            }
            else
            {
                Console.WriteLine("Yatırılacak miktar geçersiz");
            }
        }


        public virtual void ParaCek(double tutar)
        {
            if(tutar <= bakiye)
            {
                bakiye -= tutar;
                Console.WriteLine(tutar + " Tl hesabınızdan çekildi. Yeni bakiye : " + bakiye);
            }
            else
            {
                Console.WriteLine("Yetersiz bakiye");
            }
        }

        public void BakiyeGoruntule()
        {
            Console.WriteLine("Hesap numarası : " + hesapNo + " Bakiye : " + bakiye);
        }


    }
}
