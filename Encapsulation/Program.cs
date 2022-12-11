using System;

namespace Patika{

    class Encapsulation{
        static void Main(string[] args){
        
        Ogrenci ogrenci1 = new Ogrenci();
        ogrenci1.Isim ="Ayse";
        ogrenci1.Soyisim = "Yilmaz";
        ogrenci1.Sinif = 3;
        ogrenci1.OgrenciNo = 196;
        
        ogrenci1.Ogrenci_Bilgilerini_Getir();
        ogrenci1.Sinif_Dusur();
        ogrenci1.Ogrenci_Bilgilerini_Getir();
        ogrenci1.Sinif_Atlat();
        ogrenci1.Ogrenci_Bilgilerini_Getir();

        Ogrenci ogrenci2 = new Ogrenci("Deniz","Arda",194,1);
        ogrenci2.Ogrenci_Bilgilerini_Getir();
        ogrenci2.Sinif_Dusur();
        ogrenci2.Sinif_Dusur();
        ogrenci2.Ogrenci_Bilgilerini_Getir();

        }
    }

    class Ogrenci{
    private string isim; //field
    private string soyisim;
    private int ogrenciNo;
    private int sinif;

        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int OgrenciNo { get => ogrenciNo; set => ogrenciNo = value; }
        public int Sinif { 
            get => sinif; 
            set{
                if(value<1){
                    Console.WriteLine("Sinif en az 1 olabilir");
                    sinif=1;
                }
                else{
                    sinif = value;
                }
            }  
        } 

        //eğer setter olmasaydı
        //Ogrenci constructor'unun Sinif property'sini getirebilirdik
        //fakat üzerinde işlem yapamaz(değiştiremezdik)

        public Ogrenci(string ısim, string soyisim, int ogrenciNo, int sinif)
        {
            Isim = ısim;
            Soyisim = soyisim;
            OgrenciNo = ogrenciNo;
            Sinif = sinif;

            
        }

        public Ogrenci(){}

        public void Ogrenci_Bilgilerini_Getir(){
            Console.WriteLine("Öğrenci Adı:  {0}",this.isim); 
            //property'e this yardımıyla eriştik
            //yani nesne yaratıldığında constructor yardımıyla nesne üzerindeki isim bilgisini almasını sağladık

            Console.WriteLine("Öğrenci Soyadı:  {0}",this.soyisim);
            Console.WriteLine("Öğrenci No:  {0}",this.ogrenciNo);
            Console.WriteLine("Öğrenci Sınıfı:  {0}",this.sinif);    
        }

        public void Sinif_Atlat(){
            this.sinif++;
        }
        public void Sinif_Dusur(){
                this.sinif--;
        }
    }
}