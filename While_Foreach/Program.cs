using System;

namespace degisken{

    class Program{
        static void Main(string[] args){
            
            /*
            //1 den başlayarak console'dan girilen sayıya kadar sayı dahil ortalama hesaplayıp console'a yazdıran program

            int sayi = int.Parse(Console.ReadLine());
            int sayac = 1;
            int toplam = 0;
            int sonuc = 0;

            while(sayac<=sayi){ //sayaç sayıdan küçük olduğu sürece 

                toplam += sayac;
                sayac++;
            }

            sonuc = toplam / sayi;

            Console.WriteLine("Girilen sayiya kadar olan sayilarin ortalamasi" + sonuc);

            //a dan z ye kadar olan harfleri console'a yazdıran program

            char c = 'a';

            while(c <= 'z'){
                Console.WriteLine(c);
                c++;
            }
            */

            //foreach

            string[] arabalar = {"bmw", "nissan", "audi", "ford"};

            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba);
            }

            //Foreach döngüsü diziler ve koleksiyonlarla döngüsel işlemler yapmak için kullanılır. 
            //Döngünün ne kadar devam edeceğini kullanılan dizi veya koleksiyonun eleman sayısı belirler
        }
    }
}