using System;

namespace degisken{

    class Program{
        static void Main(string[] args){

            //Out parametre
            string sayi = "999";

            bool sonuc = int.TryParse(sayi,out int outSayi); 
            //TryParse sayi degiskeni stringe cevrilebilir mi diye kontrol eder ve Boolen(true,false) döndürür
            //out komutu ref komutu gibi çalışır. Referans (bellekteki yer) ile işlem yapar. 
            //Fark olarak out ile tanımlanan bir değişkene ilk değer atanması gerekmez.
            //Fakat metota giden out değişkeni belli bir değişikliğe uğramalıdır. Bunun sebebi ilk değerinin olmamasıdır. 
            //Değer ataması gönderilen metot içinde yapılmalıdır.

            //Burada TryParse komutu ile kontrol ettiğimiz sayı değişkenini, out ile tanımlanmış outSayi değişkenine atıyoruz 
            //sonuc değişkenine ise işlemin true mu, false mi olduğunu atıyoruz
            
            
            if(sonuc){ // bu komut if(sonuc==true) ile aynı şeydir
                Console.WriteLine("Başarılı");
                Console.WriteLine(outSayi);
            }
            else{
                Console.WriteLine("Başarısız");
            }

            Metotlar instance = new Metotlar();
            instance.Topla(4,5,out int toplam_sonuc); 
            //burda da out int ile toplam sonuc adında bir degisken tanımladık ancak ilk değer atamadık.
            //toplam_sonuc degiskeninin ilk degeri gittiği Topla() metotu içerisinde belirlenir. out ile tanımlanan değişkenlerin mantığı bu şekildedir
            Console.WriteLine(toplam_sonuc);


            //Metot overloading (aşırı yükleme)
            
            int ifade = 421;
            instance.Ekrana_Yazdir(Convert.ToString(ifade)); //Ekrana_Yazdir(string veri)metotuna gider
            instance.Ekrana_Yazdir(ifade); //Ekrana_Yazdir(int veri) metotuna gider
            //bu sayede aşırı yükleme yaptığımız metotu hem string hem int yazdırmak için kullanabiliriz
            instance.Ekrana_Yazdir("Tahir","Serin");

            //Metot imzası 
            //metot_adi + parametre_imzasi + parametre     
        }
    }

    class Metotlar{

        public void Topla(int a, int b, out int toplam){

            toplam=a+b;
        }

        public void Ekrana_Yazdir(string veri){
            Console.WriteLine(veri);
        }

        public void Ekrana_Yazdir(int veri){
            Console.WriteLine(veri);
        }

        public void Ekrana_Yazdir(int veri, int veri2){
            Console.WriteLine(veri + veri2);
        }

        public void Ekrana_Yazdir(string veri, string veri2){
            Console.WriteLine(veri + veri2);
        }
    }
}