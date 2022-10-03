// Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. 
// Cümledeki toplam kelime ve harf sayısını console'a yazdırın.


using System;

namespace degisken{

    class Program{
        static void Main(string[] args){
            
            
                
                Console.WriteLine("Lutfen bir cumle giriniz:");
                string cumle = Console.ReadLine();

                string[] kelimelerDizi = cumle.Split(" "); 
                //kullanıcıdan aldigimiz cumle stringini boşluk karakterlerine göre ayırıp yeni bir "kelimelerDizi" dizisini elde ediyoruz
                int uzunluk1 = kelimelerDizi.Length;
                //ve uzunlugunu alıyoruz. Bu bize kac adet kelime oldugunu verecek

                string harfler = string.Join("", kelimelerDizi);
                //olusturdugumuz "kelimelerDizi" adli diziyi bosluksuz bicimde string.Join methoduyla birlestiriyoruz
                int uzunluk2 = harfler.Length;
                //ve uzunlugunu aliyoruz. Bu bize kac adet harf oldugunu verecek

                Console.WriteLine("Girilen cümledeki kelime sayısı: {0}", uzunluk1);
                Console.WriteLine("Girilen cümledeki harf sayısı: {0}", uzunluk2);

        }
    }
}

