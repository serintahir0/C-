//Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). 
//Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. 
//Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.

using System;

namespace degisken{

    class Program{
        static void Main(string[] args){
            
            
                
                Console.WriteLine("Pozitif iki sayi giriniz: ");
                int n = Convert.ToInt32(Console.ReadLine());
                    while(n<=0){
                        Console.WriteLine("Pozitif bir sayi girmediniz. Lütfen pozitif bir sayi giriniz:");
                        n = Convert.ToInt32(Console.ReadLine());
                    }
                int m = Convert.ToInt32(Console.ReadLine());
                    while(m<=0){
                        Console.WriteLine("Pozitif bir sayi girmediniz. Lütfen pozitif bir sayi giriniz:");
                        m = Convert.ToInt32(Console.ReadLine());
                    }    

                Console.WriteLine("Lütfen " + n + " adet pozitif sayi giriniz:");

                    int[] sayilar= new int[n];

                    for(int i=0; i<n ; i++){
                        Console.Write((i+1) + ". sayi:");
                        sayilar[i] = Convert.ToInt32(Console.ReadLine());
                        while(sayilar[i]<=0){ 
                            Console.WriteLine("Pozitif bir sayi girmediniz. Lütfen tekrar giriniz.");
                            Console.Write((i+1) + ". sayi:");
                            sayilar[i] = Convert.ToInt32(Console.ReadLine());
                        }                  
                    }

                    Console.WriteLine(m + "'e esit veya tam bolunen sayilar:");

                    for(int j=0; j<n ; j++){
                        if(sayilar[j]%m == 0){
                            Console.Write(sayilar[j]+" ");
                        }
                    }
        }
    }
}

