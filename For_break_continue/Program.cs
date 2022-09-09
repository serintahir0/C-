using System;

namespace degisken{

    class Program{
        static void Main(string[] args){
            
            /*
            //ekrandan girilen sayıya kadar olan tek sayıları ekrana yazdrma
            Console.Write("Pozitif bir tamsayi giriniz:");

            int sayi = int.Parse(Console.ReadLine());
            //Console.Readline() ekrandan string okur. Bu yüzden int.Parse() kullanarak okuduğumuz değeri int tipine dönüştürüyoruz.

            for(int i=1 ; i<=sayi ; i++){
                if(i%2==1){
                    Console.WriteLine(i);
                }
            }
            */

            /*
            //1 ile 1000 arasındaki tek sayıların toplamını ve çift sayıların toplamını ekrana yazdırma

            int tek=0, cift=0;
            for(int i = 1 ; i<=1000 ; i++){
                if(i%2 == 0){
                    cift += i; // cift = cift + i;
                }
                else{
                    tek += i; // tek = tek + i;
                }
            }
            Console.WriteLine("Tek Sayilarin Toplami :" + tek);
            Console.WriteLine("Cift Sayilarin Toplami :" + cift);
            */

            //break, continue kullanımı 

            for(int i = 1; i <= 10; i++){
                if(i == 4){
                    break;   //i = 4 olduğunda döngü kırılır ve döngüden sonraki işleme geçilir.
                }
                Console.WriteLine(i);
            }

            for(int i = 1; i <= 10; i++){
                if(i == 4){
                    continue;  // i = 4 olduğunda o adım atlanır ve i = 5 koşulu kontrol edilir. 
                }
                Console.WriteLine(i);
            }

            // for(;;) sonsuz döngüdür
        }
    }
}