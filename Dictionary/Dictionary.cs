using System;
using System.Collections.Generic;

namespace degisken{

    class Program{
        static void Main(string[] args){
            
            Dictionary<int,string> kullanicilar = new Dictionary<int, string>();
            //verileri anahtar ve veriler olarak tutarlar. 

            kullanicilar.Add(10,"Ayşe Yılmaz");
            kullanicilar.Add(12,"Tahir Serin");
            kullanicilar.Add(18,"Özcan Coşar");
            kullanicilar.Add(20,"Deniz Arda");

            //Dizinin elemanlarına erişim

            Console.WriteLine(kullanicilar[12]); //12. indexteki elemani getir
            foreach (var item in kullanicilar){
                Console.WriteLine(item);
            }

            //Count
            Console.WriteLine(kullanicilar.Count());

            //Contains
            Console.WriteLine(kullanicilar.ContainsKey(12)); //true döner
            Console.WriteLine(kullanicilar.ContainsValue("Tahir Serin")); //true döner

            //Remove
            kullanicilar.Remove(18);
            foreach (var item in kullanicilar){
                Console.WriteLine(item);
            }

            //Keys: Dizinin elemanının bulunduğu index'tir. Aynı zamanda verilerin anahtarıdır.
            foreach (var item in kullanicilar.Keys)
            {
                Console.WriteLine(item);
            }

            //Values : Dizinin elemanlarıdır aynı zamanda Key'deki verilerdir --> örnek: Key:12 Value:"Tahir Serin"
            foreach (var item in kullanicilar.Values)
            {
                Console.WriteLine(item);
            }



        }
    }
}