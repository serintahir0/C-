using System;

namespace degisken{

    class Program{
        static void Main(string[] args){
            
            // Atama ve İşlemli atama
            int x = 3;
            int y = 3; 
            y = y+2;
            Console.WriteLine(y);
            y += 2;     //y değişkenine 2 sayısını ekle, bu işlemden elde edilen değeri y değişkenine ata
            // uzun hali y+=2 ---> y = y+2 
            Console.WriteLine(y);
            

            //Mantıksal operatörler || , &&
            bool isSuccess = true;
            bool isCompleted = false;

            if(isSuccess && isCompleted){
                Console.WriteLine("Perfect!");
            }
            if(isSuccess || isCompleted){
                Console.WriteLine("Great!");
            }
            if(isSuccess && !isCompleted){
                Console.WriteLine("Fine!");
            }
            
            // <, >, <= , >= , ==, !=

            int a=3, b=4;
            bool sonuc = true;

            if(a == b){
                Console.WriteLine(sonuc);
            }
            if(a != b){
                Console.WriteLine(sonuc);
            }
            if(a < b){
                Console.WriteLine(sonuc);
            }
            if(a > b){
                Console.WriteLine(sonuc);
            }
            if(a <= b){
                Console.WriteLine(sonuc);
            }
            if(a >= b){
                Console.WriteLine(sonuc);
            }

            int sayi1 = 10;
            int sayi2 = 5;

            int sonuc1 = sayi1 / sayi2;
            Console.WriteLine(sonuc1);

            int sonuc2 = sayi1 * sayi2;
            Console.WriteLine(sonuc2);

            int sonuc3 = sayi1 + sayi2;
            Console.WriteLine(sonuc3);

            int sonuc4 = sayi1 - sayi2;
            Console.WriteLine(sonuc4);

            int sonuc5 = sayi1/ sayi2;
            Console.WriteLine(sonuc5);

            int sonuc6 = sayi1 % sayi2;
            Console.WriteLine(sonuc6);

            int sonuc7 = sayi1++;
            Console.WriteLine(sonuc7);

            int sonuc8 = sayi2--;
            Console.WriteLine(sonuc8);
        }
    }
}