using System;

namespace Patika{

    class Siniflar{
        static void Main(string[] args){
             //Bir sınıfın static olamayan üyelerine nesneler aracılığıyla erişirken 
             //static olan metotlara ve özelliklere ise nesne oluşturmadan o sınıfın ismi aracılığıyla erişiriz.

             //bir class içinde static olmayan ögeler nesneye atanır ve nesne sayesinde erişilebilir
             //fakat static ögeler class'a atanır. Nesne oluşturmaya gerek olmadan direk class aracılığıyla erişilebilir


            Console.WriteLine("Çalışan Sayısı: {0}", Calisan.CalisanSayisi);
            Calisan calisan1 = new Calisan("Tahir","Serin","Yazılım");
            Console.WriteLine("Çalışan Sayısı: {0}", Calisan.CalisanSayisi);
            Calisan calisan2 = new Calisan("Ali","Sattarzadeh","Yazılım");
            Calisan calisan3 = new Calisan("Berkay","Ocan","Yazılım");

            //bir sınıf static olursa sınıf icindeki her öge static olmalıdır.

            Console.WriteLine("Toplama islemi sonucu: {0}",Islemler.Topla(500,423)); 
            Console.WriteLine("Cikarma islemi sonucu: {0}",Islemler.Cikar(500,423)); 
            //dikkat edilmesi gereken nokta Islemler class'ındaki veriye bir nesne oluşturmadan direk,
            //Islemler.FonksiyonAdı şeklinde eriştik.

        }
    }
    class Calisan{

        private static int calisanSayisi;

        public static int CalisanSayisi { get => calisanSayisi; }

        private string Isim;
        private string Soyisim;
        private string Departman;

        static Calisan(){ //static constructor(kurucu) 
            calisanSayisi = 0;
        }
        //kod, nesne oluşturmadığından ilk önce bu static kurucuya uğrayıp verilere erişir.
        //burdan ilk olarak calisanSayisi degiskenine 0 atandıgı bilgisini alır.


        public Calisan(string isim, string soyisim, string departman) //consturctor(kurucu)
        {
            this.Isim = isim;
            this.Soyisim = soyisim;
            this.Departman = departman;
            calisanSayisi++;
        }
        //ardından nesne oluşturulduktan sonra kod static olmayan kurucuya uğrar
        //ve buradaki verilere erişir
    }
    static class Islemler{
        public static long Topla(int sayi1, int sayi2){
            return sayi1+sayi2;
        }
        public static long Cikar(int sayi1, int sayi2){
            return sayi1-sayi2;
        }
    }
}