using System;

namespace Patika{

    class Structs{
        static void Main(string[] args){
            /*
            - Class lar referans tipli özellikler gösterir, Yapılar ise değer tipli özellikler gösterirler. En temel fark budur.
            - Diğer struct ya da sınıflardan kalıtım almazlar.
            - Interface'lerden kalıtım alabilirler.
            - new anahtar sözcüğü ile nesneleri yaratılabilir.
            - Sınıflar gibi metot, property ve field'lardan oluşurlar.
            - Sınıf içerisinde struct, struct içerisinde de sınıf oluşturulabilir.
            - Static üye barındırabilirler.

            struct Ogrenci {
                public string Isim;
                public string Soyisim {get;set;}
                public static int OgrenciSayısı=0;
            }
            */
            Dikdortgen dikdortgen1 = new Dikdortgen();
            dikdortgen1.KisaKenar = 3;
            dikdortgen1.UzunKenar = 4;
            Console.WriteLine("Class Alan Hesabı: {0}", dikdortgen1.AlanHesapla());

            Dikdortgen_Struct dikdortgen_Struct = new Dikdortgen_Struct();
            dikdortgen_Struct.KisaKenar=3;
            dikdortgen_Struct.UzunKenar=4;
            Console.WriteLine("Struct Alan Hesabı: {0}", dikdortgen_Struct.AlanHesapla());
            
            Dikdortgen_Struct dikdortgen_Struct1; //bir diger struct tanımlama şekli
            dikdortgen_Struct.KisaKenar=3;
            dikdortgen_Struct.UzunKenar=4;
            //bu tanımlamada inital degerler kendiliginden atanamaz. 
            //new olmadan tanımladığımız bicimde,
            //33. ve 34. satırlarda oldugu gibi initial degerleri kendimiz tanımlamalıyız

            Dikdortgen_Struct dikdortgen_Struct2 = new Dikdortgen_Struct(3,4);
            Console.WriteLine("Struct Alan Hesabı: {0}", dikdortgen_Struct.AlanHesapla());
            
            //16 byte'a kadar olan verileri saklamak icin struct kullanması uygunken 
            //16 byte'dan büyük veriler icin sınıf yapılarını kullanmak daha uygundur
        }

        class Dikdortgen{
            public int KisaKenar;
            public int UzunKenar;

            public long AlanHesapla(){
                return KisaKenar*UzunKenar;
            }
        }

        struct Dikdortgen_Struct{
            public int KisaKenar;
            public int UzunKenar;

            public long AlanHesapla(){
                return KisaKenar*UzunKenar;
            }

            public Dikdortgen_Struct(int kisaKenar, int uzunKenar) //costructor
            {
                KisaKenar = kisaKenar;
                UzunKenar = uzunKenar;
            }
        }
    }
}