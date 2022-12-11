using System;

namespace Patika{

    class Siniflar{
        static void Main(string[] args){
             
            // Söz Dizimi
            // class SinifAdi
            // {
            //      Erişim_Belirleyici Veri_Tipi Özellik_Adı;
            //      Erişim_Belirleyici Geri_Dönüş_Tipi Metot_Adı(Parametreler);
            //      {
            //          Komutlar
            //      }

            // Erişim Belirleyiciler
            // Public : her yerden erişilebilen metotlar Public tanımlanır
            // Private : sadece tanımlandığı sınıf içinden erişilebilen metotlar Private tanımlanır
            // Internal : sadece kendi bulunduğu proje içerisinden erişilebilen metotlar Internal tanımlanır
            // Protected : sadece tanımlandığı sınıfta veya o sınıftan kalıtım alan sınıflarda kullanılabilen metotlar Protected tanımlanır

            Calisan calisan1 = new Calisan();
            calisan1.Ad = "Ayşe";
            calisan1.Soyad ="Kara";
            calisan1.No = 29150234;
            calisan1.Departman = "İnsan Kaynakları";

            calisan1.CalisanBilgileri();
        }
    }

    class Calisan{
        public string Ad;
        public string Soyad;
        public string Departman;
        public int No;

        public void CalisanBilgileri(){
            Console.WriteLine("Çalışan Adı:{0}",Ad);
            Console.WriteLine("Çalışan Soyadı:{0}",Soyad);
            Console.WriteLine("Çalışan Numarası:{0}",No);
            Console.WriteLine("Çalışan Departmanı:{0}",Departman);


        }
    }
}