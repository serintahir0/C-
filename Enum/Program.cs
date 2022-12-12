using System;

namespace Patika{

    class Enum{
        static void Main(string[] args){
            //"enum" anahtar kelimesi enumeration yani numaralandırma kelimesinden gelir. 
            //Sayısal verilerı string ifadelerle saklamanızı sağlar. 
            //Okunabilirliğe katkısı da tam olarak burdan gelir diyebiliriz.
            
            Console.WriteLine(Gunler.Pazar);
            Console.WriteLine((int)Gunler.Cumartesi); //Cumartesi elemanının sayısal verisine erişmek istersek bu şekilde tip dönüşümü yaparız
            //cumaya 23 atarsak cumartesi ardışık olarak 24 alır

            Console.WriteLine("Havanın derecesini girin: ");
            int sicaklik = Convert.ToInt32(Console.ReadLine());

            if(sicaklik<=(int)HavaDurumu.normal){
                Console.WriteLine("Dışarı çıkmak için havanın ısınmasını bekle");
            }
            else if(sicaklik>=(int)HavaDurumu.sicak){
                Console.WriteLine("Dışarı çıkmak için çok sıcak bir gün");
            }
            else if(sicaklik>=(int)HavaDurumu.normal && sicaklik<=(int)HavaDurumu.coksicak){
                Console.WriteLine("Hadi dışarı çıkalım");

            }
        }
    }
    
    enum Gunler{
        Pazartesi,
        Sali,
        Carsamba,
        Persembe,
        Cuma=23,
        Cumartesi,
        Pazar
    }

    enum HavaDurumu{
        normal=20,
        sicak=25,
        coksicak=30,
        soguk=-5
    }
}