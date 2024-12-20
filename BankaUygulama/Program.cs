using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaUygulama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Bir bankada, farklı hesap türlerini temsil eden bir yazılım geliştirilecektir.
            Bu yazılımda kapsülleme, miras alma, polimorfizm ve abstract sınıflar kullanılarak 
            farklı hesap türleri arasında işlemler yapılacak. 
            Banka sisteminde farklı hesap türleri bulunmaktadır: Vadesiz Hesap, Vadeli Hesap ve Kredi Hesap. 
            Her hesap türü kendi işlem özelliklerine sahiptir ve 
            bu hesaplar temel hesap özelliklerini paylaşırken, bazı işlemler kendine özgü olacaktır.             
            */

            /*
             Senaryo:

             Bir bankada Hesap adında bir abstract sınıf bulunmaktadır ve tüm hesap türleri bu sınıftan türeyecek.
             Banka müşterilerinin hesap bakiyeleri olacak ve bu bakiyeler üzerinde işlem yapabilecekler.
             Hesap türleri arasında vadesiz hesap, vadeli hesap ve kredi hesabı yer alacak.
             Her hesap türü kendi faiz oranını, para çekme limitini ve belirli işlemleri farklı 
             şekilde gerçekleştirecek. Ayrıca her hesabın bilgilerine yalnızca yetkili kullanıcılar erişebilecek.
             */

            /*
             Gereksinimler:

                1-Hesap sınıfı bir abstract sınıf olacak ve tüm hesap türlerinin temel özelliklerini ve metodlarını içerecek.
                  Bu sınıf, her hesabın bakiye görüntüleme, para yatırma, para çekme gibi ortak fonksiyonları tanımlayacak.
                2-Vadesiz Hesap, Vadeli Hesap ve Kredi Hesap gibi alt sınıflar, Hesap sınıfından türeyecek ve her biri
                  kendine özgü işlem özelliklerini belirleyecek.
                3-Kapsülleme (Encapsulation) kullanarak, her hesap türünün bakiyesi ve hesap numarası gizlenecek.
                4-Polimorfizm kullanarak, farklı hesap türlerinin aynı metodu farklı şekilde kullanmasını sağlayacağız.
                5-Abstract sınıf kullanılarak, ortak bir işlevsellik ve temel metodlar tanımlanacak.
             */

            /*
             Açıklama:

            Hesap Sınıfı:
                Hesap sınıfı, tüm hesapların temel özelliklerini içerir. Bu sınıfın metotları, para yatırma (ParaYatir), 
                para çekme (ParaCek), bakiye görüntüleme (BakiyeGoruntule) gibi ortak işlemleri tanımlar.
                FaizOrani metodu abstract olarak tanımlanmıştır, çünkü her hesap türü farklı faiz oranları kullanabilir.

            VadesizHesap, VadeliHesap ve KrediHesap Sınıfları:
                VadesizHesap, VadeliHesap ve KrediHesap sınıfları, Hesap sınıfından türetilmiştir. Her biri FaizOrani 
                metodunu farklı şekilde implement eder.
                VadeliHesap faiz ekleyebilir, ancak para çekemez.
                KrediHesap bir kredi limiti ile gelir ve bu limit dahilinde işlem yapılabilir.

            Kapsülleme:
                Hesap numarası ve bakiye gibi bilgiler dışarıdan doğrudan erişilemez. Bu bilgilere yalnızca 
                getter ve setter metotları aracılığıyla erişim sağlanır.

            Polimorfizm:
                ParaCek metodu, alt sınıflarda farklı şekilde uygulanır. KrediHesap ve VadeliHesap sınıflarında,
                para çekme işlemi farklı kurallara göre çalışır.
             */



            //farklı hesap türleri oluşturuluyor
            Hesap vadesizHesap = new VadesizHesap("V1213",4000);
            Hesap vadeliHesap = new VadeliHesap("V1548",5000);
            Hesap krediHesabi = new KrediHesabi("K5489",5000,50000);

            //Hesaplara işlem yapma
            vadesizHesap.BakiyeGoruntule();
            vadesizHesap.ParaYatir(500);
            vadesizHesap.ParaCek(150);


            Console.WriteLine();


            vadeliHesap.BakiyeGoruntule();
            vadeliHesap.ParaYatir(1400);
            vadeliHesap.ParaCek(560);  //vadeli hesaptan para çekme işlemi olmadığı için bu işlem gerçekleşmeyecek
            ((VadeliHesap)vadeliHesap).FaizEkle(); //Faiz ekleniyor


            Console.WriteLine();


            krediHesabi.BakiyeGoruntule();
            krediHesabi.ParaYatir(2500);
            krediHesabi.ParaCek(8600);
            ((KrediHesabi)krediHesabi).KrediLimitiGoruntule();


            Console.ReadKey();




        }
    }
}
