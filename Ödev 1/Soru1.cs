//Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). 
//Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.

using System;

namespace degisken{

    class Program{
        static void Main(string[] args){
            
            
                
                Console.WriteLine("Pozitif bir sayi giriniz: ");
                int n = int.Parse(Console.ReadLine());
                    while(n<=0){
                        Console.WriteLine("Pozitif bir sayi girmediniz. Lütfen pozitif bir sayi giriniz:");
                        n = Convert.ToInt32(Console.ReadLine());
                    }   

                    Console.WriteLine("Lütfen " + n + " adet pozitif sayi giriniz:");

                    int[] sayilar= new int[n];

                    for(int i=0; i<n ; i++){
                        sayilar[i] = Convert.ToInt32(Console.ReadLine());
                        while(sayilar[i]<=0){ 
                            Console.WriteLine("Pozitif bir sayi girmediniz. Lütfen pozitif bir sayi giriniz:");
                            sayilar[i] = Convert.ToInt32(Console.ReadLine());

                        }                  
                    }
                    Console.WriteLine("Girilen cift sayilar: ");
                    for(int j=0; j<n ; j++){
                        if(sayilar[j]%2 == 0){
                            Console.Write(sayilar[j]+" ");
                        }
                    }
        }
    }
}


                    