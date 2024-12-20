using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaUygulama
{
    public class VadeliHesap : Hesap
    {
        public VadeliHesap(string hesapNo, double bakiye) : base(hesapNo, bakiye)
        {
        }

        public override double FaizOrani()
        {
            return 5.0; 
        }


        public override void ParaCek(double tutar)
        {
            Console.WriteLine("Vadeli hesaptan para çekilemez.Sadece faiz eklenebilir");
        }

        public void FaizEkle()
        {
            double faiz = Bakiye * FaizOrani() / 100;          
            Console.WriteLine("Vadeli hesap faiz oranı : " + FaizOrani() + "%." + "Faiz eklenmiştir : " + faiz + "TL.");
        }
    }
}
