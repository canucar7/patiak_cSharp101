    internal class Program
    {
        private static void Main(string[] args)
        {

            Ogrenci ogrenci1 = new Ogrenci();
            ogrenci1.Isim="Murat";
            ogrenci1.Soyİsim="Kürkçü";
            ogrenci1.OgrenciNo=331;
            ogrenci1.Sinif=3;
            ogrenci1.OgrenciBilgileriniGetir();

            ogrenci1.SinifAtla();
            ogrenci1.OgrenciBilgileriniGetir();


            Ogrenci ogrenci2 = new Ogrenci("Selim","Atmaca",115,1);
            ogrenci2.SinifDusur();
            ogrenci2.SinifDusur();
            ogrenci2.OgrenciBilgileriniGetir();

             
            
            


            
        }
    }

    class Ogrenci
    {
        private string isim;

        private string soyisim;

        private int ogrenciNo;

        private int sinif;


    public string Isim
    {
        get {return isim;} 
        set {isim = value;}   
    } 
    
    public string Soyİsim { get => soyisim; set => soyisim = value; }
    
    public int OgrenciNo { get => ogrenciNo; set => ogrenciNo = value; }

    public int Sinif 
    { 
        get => sinif;
        set
        { 
            if (value<1)
            {
                Console.WriteLine("Sinif en az 1 olabilir!");
                sinif=1;
            }else
                sinif = value;
        } 
    }


    public Ogrenci(string ısim, string soyİsim, int ogrenciNo, int sinif)
    {
        Isim = ısim;
        Soyİsim = soyİsim;
        OgrenciNo = ogrenciNo;
        Sinif = sinif;
    }


    public Ogrenci(){}


    public void OgrenciBilgileriniGetir()
    {
        Console.WriteLine("***** Öğrenci Bilgileri **********");
        Console.WriteLine("Öğrenci Adı : {0}",this.Isim);
        Console.WriteLine("Öğrenci Soyadı : {0}",this.Soyİsim);
        Console.WriteLine("Öğrenci No : {0}",this.OgrenciNo);
        Console.WriteLine("Öğrenci Sınıfı : {0}",this.Sinif);


    }



    public void SinifAtla()
    {
        this.Sinif=this.Sinif+1;
    }

    public void SinifDusur()
    {
        this.Sinif=this.Sinif-1;
    }




    





    }