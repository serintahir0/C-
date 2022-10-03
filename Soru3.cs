// Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). 
// Sonrasında kullanıcıdan n adet kelime girmesi isteyin. 
// Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.

using System;

namespace degisken{

    class Program{
        static void Main(string[] args){
            
            
                
                Console.WriteLine("Pozitif bir sayi giriniz: ");
                int n = Convert.ToInt32(Console.ReadLine());
                    while(n<=0){
                        Console.WriteLine("Pozitif bir sayi girmediniz. Lütfen pozitif bir sayi giriniz:");
                        n = Convert.ToInt32(Console.ReadLine());
                    }

                Console.WriteLine("Lütfen " + n + " adet kelime giriniz:");

                string[] kelimeler= new string[n];

                    for(int i=0; i<n ; i++){ //okuma
                        Console.Write((i+1) + ". kelime:");
                        kelimeler[i] = Console.ReadLine();            
                    }

                    Console.WriteLine("Girilen kelimelerin sondan basa dogru yazdirilmasi:");
                    
                    //1. Yol
                    /*Array.Reverse(kelimeler);
                    foreach (var item in kelimeler){
                    Console.WriteLine(item);
                    }*/

                    //2. Yol
                    for(int j=n-1 ; j>=0 ; j--){
                        Console.WriteLine(kelimeler[j]);
                    }
        }
    }
}

