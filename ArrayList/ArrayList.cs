using System;
using System.Collections;

namespace degisken{

    class Program{
        static void Main(string[] args){
            ArrayList liste = new ArrayList();
            liste.Add(3);
            liste.Add("Ahmet");
            liste.Add(true);
            liste.Add('A');

            //arrayList icindeki verilere erisme
            Console.WriteLine(liste[1]);

            foreach (var item in liste){
                Console.WriteLine(item);
            }

            //AddRange
            string[] renkler = {"kirmizi", "sari", "yesil"};
            liste.AddRange(renkler);
            List<int> sayilar = new List<int>(){1,2,3,4,5};
            liste.AddRange(sayilar);

            //gördügümüz üzere ArrayList Collections'umuza istedigimiz veri tipinde degiskeni ekleyebiliyoruz
            //fakat direk sıralamak istedigimizde hata verecektir

            //Sort
            //liste.Sort(); //--> compileTime'da hata vermezken runTime'da hata verir

            //siralamak icin sadece tamsayilar kullanilmali

            ArrayList sayiListesi = new ArrayList();
            sayiListesi.AddRange(sayilar);
            sayiListesi.Sort(); //bu kısım hata vermeyecektir

            //BinarySearch
            Console.WriteLine(sayiListesi.BinarySearch(4)); 
            //BinarySearch kullanabilmek icin kendi icinde siralanmis bir list kullanilmasi gerekir
            //verilen indexteki elemani getirir

            //Reverse
            //tam ortasından aynalar. En baştaki elemani en sona, en sondaki elemani en basa gececek sekilde calisir
            //Yani listeyi ters cevirir

            sayiListesi.Reverse(); 

            //Clear : Listeyi temizler

            sayiListesi.Clear();

        }
    }
}