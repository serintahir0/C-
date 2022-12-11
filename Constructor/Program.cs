using System;

namespace Patika{

    class Constructor{
        static void Main(string[] args){
            /*
            Bir sınıftan bir nesne oluşturulduğunda biz tanımlamasak bile,
            arka planda çalışan varsayılan yapıcı metotlara kurucu yada constructor denir. 
            Sınıf nesnesi ilk oluşturulduğunda yapılmasını istediğimiz işleri kurucu metotlar içerisinde yaparız.
            
            Kurucu(Yapıcı) metot tanımlarken dikkat edilmesi gereken noktalar:
                - Kurucu metotların isimleri sınıf isimleri ile aynı olmak zorundadır.
                - Public olarak bildirilmeleri gerekir.
                - Geri dönüş değerleri yoktur.

            */
            Calisan calisan1 = new Calisan("Ayşe","Kara","İnsan Kaynakları",29150234);
            /* Constructor kullanarak tanımladigimiz calisan nesnesi,
            bir önceki derste yaptığımız şekilde, aşağıdaki gibi uzunca tanımlanabilir. 
            Fakat constructor daha okunabilir ve daha avantajlıdır

            calisan1.Ad = "Ayşe";
            calisan1.Soyad ="Kara";
            calisan1.No = 29150234;
            calisan1.Departman = "İnsan Kaynakları";*/

            calisan1.CalisanBilgileri(); //baska bir class'taki fonksiyona bu sekilde eleman gönderiyoruz
        }
    }

    class Calisan{
        public string Ad;
        public string Soyad;
        public string Departman;
        public int No;

        public Calisan(string ad, string soyad, string departman, int no){ //constructor
            this.Ad = ad;
            this.Soyad = soyad;
            this.No = no;
            this.Departman = departman;
        }

        public Calisan(){} //constructor overload (aşırı yükleme) 
        //hiç bir parametre almamış constructor. Nesne hic bir özelliğe sahip olmayabilir
        //kurucu tanımlanmadığında buna benzer bir kurucu (constructor) arka planda çalışır
        //string = null atar
        //int = 0 atar
        //boolen = false atar
        //constructor tanımlanmadığında bile arka planda bu şekilde default değerler atar

        public Calisan(string ad, string soyad){ //constructor overload (aşırı yükleme)
            this.Ad = ad;
            this.Soyad = soyad;
        }
        //daha az parametre almış constructor. Nesne sadece string ad ve string soyad parametrelerini almış olabilir.

        
        public void CalisanBilgileri(){
            Console.WriteLine("Çalışan Adı:{0}",Ad);
            Console.WriteLine("Çalışan Soyadı:{0}",Soyad);
            Console.WriteLine("Çalışan Numarası:{0}",No);
            Console.WriteLine("Çalışan Departmanı:{0}",Departman);
        }
    }
}