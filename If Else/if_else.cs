using System;

namespace degisken{

    class Program{
        static void Main(string[] args){

            int time = DateTime.Now.Hour;

            if(time>=6 && time<11 ){
                Console.WriteLine("Günaydın");
            }
            else if (time<=18){
                Console.WriteLine("İyi Günler");
            }
            else{
                Console.WriteLine("İyi Geceler");
            }

            string sonuc = time <=18 ? "İyi Günler" : "İyi Geceler"; 
            Console.WriteLine(sonuc);

            //Veya 
            //Console.Writeline(time <=18 ? "İyi Günler": "İyi Geceler");
            //şeklinde de yazabiliriz.

            //Burdaki soru işareti koşulu (if komutunu) belirtir. Eğer time 18 den küçük veya eşitse İyi günler yazdırır.
            // : komutu da else komutunu belirtir. Eğer time 18 den büyükse İyi geceler yazdırır.

            sonuc = time >= 6 && time < 11 ? "Günaydın" : time <= 18 ? "İyi Günler" : "İyi Geceler"; 
            Console.WriteLine(sonuc);


            //Burdaki : ..... ? ifadesi else if komutunu belirtir. Bu aralığa koşul yazılır.
        }
    }
}