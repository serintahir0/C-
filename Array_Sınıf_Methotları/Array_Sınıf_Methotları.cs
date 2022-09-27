using System;

namespace degisken{

    class Program{
        static void Main(string[] args){
            
           int[] sayi_dizisi = {1,2,5,3,77,892,16,0};
                
            foreach (var item in sayi_dizisi){
                Console.WriteLine(item);
            }

            // Sort : diziyi sıralamar
            // Array.Sort(kullanılacak_dizi); şeklinde yapılır

            Array.Sort(sayi_dizisi);
            foreach (var item in sayi_dizisi){
                    Console.WriteLine(item);
            }

            // Clear : dizi içerisinde verilen indexten başlayarak, verilen eleman sayısı kadar değeri sıfırlar
            // Array.clear(kullanılacak_dizi , başlanacak_index , temizlenecek_eleman_sayısı); şeklinde yapılır

            Array.Clear(sayi_dizisi,2,2);
            foreach (var item in sayi_dizisi){
                    Console.WriteLine(item);
            }

            // Reverse : diziyi ters çevirir
            // Array.Reverse(kullanılacak_dizi); şeklinde yapılır

            Array.Reverse(sayi_dizisi);
            foreach (var item in sayi_dizisi){
                    Console.WriteLine(item);
            }

            // IndexOf : dizi üzerinde bir elemanın var olup olmadığını kontrol eder, varsa index'ini döner
            // Array.IndexOf(kullanılacak_dizi , aranacak_eleman); şeklinde yapılır

            Console.WriteLine(Array.IndexOf(sayi_dizisi, 77));

            // Resize : yeniden boyutlandırma yapar
            Array.Resize<int>(ref sayi_dizisi, 9); //integer tipindeki sayi_dizisi dizisinin boyutunu 9 yap
            sayi_dizisi[8] = 99;
            foreach (var item in sayi_dizisi){
                    Console.WriteLine(item);
            }


        }
    }
}