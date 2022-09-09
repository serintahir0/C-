using System;

namespace degisken{

    class Program{
        static void Main(string[] args){
            
            /*
            string[] renkler = new string[5]; //eleman sayısı belli, elemanları belli olmayan dizi tanımlama
            string[] hayvanlar = {"kedi","köpek", "kuş", "maymun"}; //elemanları belli olan dizi tanımlama (eleman sayısı bellidir)

            int[] dizi;
            dizi = new int[5]; //diziyi önden oluşturma ve sonradan eleman sayısını tanımlama

            renkler[0] = "mavi"; //dizi elemanı ekleme (elemana string atama)
            dizi[3] = 3 ; //dizi elemanına integer değer atama
            
            */

            //döngülerle dizi kullanımı

            //klavyeden girilen n tane sayının ortalamasını alan program
            
           
            Console.WriteLine("Lütfen dizinin eleman sayisini giriniz:");
            int diziUzunlugu = int.Parse(Console.ReadLine());
            int[] sayiDizisi= new int[diziUzunlugu];
            

            for (int i = 0; i < diziUzunlugu; i++)
            {
                Console.WriteLine("Lütfen {0}. elemani giriniz:",i+1);
                sayiDizisi[i] = int.Parse(Console.ReadLine());
            }

            int toplam = 0;

            foreach (var sayi in sayiDizisi)
            {
                toplam += sayi;
            }
            Console.WriteLine("Ortalama:" + toplam/diziUzunlugu);

        }
    }
}