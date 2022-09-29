using System;

namespace degisken{

    class Program{
        static void Main(string[] args){
            
            //metot syntaxı :
            //  erisim_belirteci geri_donus_tipi metot_adi(parametre_listesi/arguman){ 
            //  ...komutlar...
            //  return ... ; 
            //  }
            //erisim belirtecleri: public, private, ...
            //geri dönüs tipi: void, int, string, ...

            int a=2, b=3;
            int sonuc = topla(a,b);
            Console.WriteLine(sonuc);

            Metotlar ornek = new Metotlar(); //Metotlar class'ına erişebilen, ondan faydalanabilen bir değişken oluşturduk
            ornek.ekrana_yazdir(Convert.ToString(sonuc)); //Oluşturduğumuz ornek degiskeni sayesinde Metotlar class'ındaki ekrana_yazdir metotuna erişip onu kullandık
            //ekrana_yazdir metotu string aldığı ve biz sonuc degiskenini int olarak gönderdigimiz icin hata vermemesi adına Convert.ToString() ile sonuc degiskenini string'e cevirdik
            
            int sonuc2 = ornek.arttir_ve_topla(a,b);
            ornek.ekrana_yazdir(Convert.ToString(sonuc2));

            //referanslar sayesinde methota erişmek için ref komutunu kullandık
            int sonuc3 = ornek.arttir_ve_topla2(ref a, ref b);
        }

        static int topla(int deger1, int deger2){
            
            return(deger1+deger2);

        }
    }

    class Metotlar{

        public void ekrana_yazdir(string x){
            Console.WriteLine(x);
        }

        public int arttir_ve_topla(int deger1, int deger2){
            deger1++;
            deger2++;

            return deger1+deger2;
        }

        //referans kullanarak arttir_ve_topla2 fonksiyonunu yazalım. 
        //ref ile parametrelerin ve degiskenlerin bellekteki yerini kullanarak islem yapariz.
        public int arttir_ve_topla2(ref int deger1, ref int deger2){
            deger1++;
            deger2++;

            return deger1+deger2;
        }
    }
}