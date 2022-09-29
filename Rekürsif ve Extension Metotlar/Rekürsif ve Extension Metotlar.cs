using System;

namespace degisken{

    class Program{
        static void Main(string[] args){
            

            //Rekürsif - Öz Yinelemeli
            // 3*3*3*3 = 3^4
            int result = 1;

            for (int i = 1; i < 5; i++)
            {
                result = result*3;
            }
            Console.WriteLine(result);

            islemler instance = new();
            Console.WriteLine(instance.Expo(3,4));  

            //Extension methotlar
            string ifade = "Tahir Serin";
            bool sonuc = ifade.bosluk_kontrolu();
            Console.WriteLine(sonuc);

            if(sonuc){
                Console.WriteLine(ifade.bosluk_sil());
            }
            
            Console.WriteLine(ifade.buyuk_harfe_cevir());
            Console.WriteLine(ifade.kucuk_harfe_cevir());

            int[] dizi = {1,5,2,6,1,5,8,9};

            dizi.dizi_sirala();
            dizi.ekrana_yazdir();

            int sayi2 = 5;
            Console.WriteLine(sayi2.cift_mi());
            Console.WriteLine(ifade.stringin_ilk_karakterini_al());

            
        }
    }

    public class islemler{

        public int Expo(int sayi, int us){
            if(us<2){
                return sayi;
            } 
            else{
                return Expo(sayi,(us-1))*sayi;
            }
        }

        //Expo(3,4) açılımı 
        //Expo(3,3) * 3
        //(Expo(3,2)*3)*3
        //((Expo(3,1)*3)*3)*3
        //(((3)*3)*3)*3 = 3^4
    }

    public static class Extension{
        
        public static bool bosluk_kontrolu(this string param){
            return param.Contains(" ");
        }

        public static string bosluk_sil(this string param){
            string[] dizi = param.Split(" "); //diziyi verilen ifadeye (" ") göre ayırır ve bir diziye atar
            //örnek dizi = "ahmet bana bak" --->>>> dizi = {ahmet,bana,bak};
            return string.Join("",dizi); //diziyi verilen ifadeyle ("") (boşluksuz ifade) birleştirir
            //dizi = {ahmet,bana,bak}; --->>> dizi = "ahmetbanabak";

            //yani bu iki metotla (Split, Join) diziyi belirlenen elemanlarca ayırıp birleştirdik
        }

        public static string buyuk_harfe_cevir(this string param){
            return param.ToUpper();
        }

        public static string kucuk_harfe_cevir(this string param){
            return param.ToLower();
        }

        public static int[] dizi_sirala(this int[] param){
            Array.Sort(param);
            return param; 
        }    

        public static void ekrana_yazdir(this int[] param){
            foreach (var item in param)
            {
                Console.WriteLine(item);
            }
        }    
        
        public static bool cift_mi(this int param){
            /*if(param%2==0){
                return true;
            }
            else{
                return false;
            }*/

            return param%2==0;
        }  

         public static string stringin_ilk_karakterini_al(this string param){
            return param.Substring(0,1); //Substring metodu 0. indexten başlayarak 1 karakter getirir
        }  
    }
}