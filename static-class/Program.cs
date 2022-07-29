    internal class Program
    {
        private static void Main(string[] args)
        {

            Console.WriteLine("Çalışan sayısı : {0}",Calısan.CalisanSayisi);

            Calısan calısan1 = new Calısan("Salih","Önder","İnsan Kaynakları");
            Console.WriteLine("Çalışan sayısı : {0}",Calısan.CalisanSayisi);
            Calısan calısan2 = new Calısan("Uğur","Dönmez","İnsan Kaynakları");
            Calısan calısan3 = new Calısan("Yaren","Bulut","İnsan Kaynakları");
            
            Console.WriteLine("Çalışan sayısı : {0}",Calısan.CalisanSayisi);
            

           Console.WriteLine("Toplama İşlemi sonucu {0}",Islemler.Toplama(100,200));
           Console.WriteLine("Toplama İşlemi sonucu {0}",Islemler.Cikarma(400,50));

            

            
            
        }
    }

    class Calısan
    {

        private static int calisanSayisi;

        public static int CalisanSayisi { get => calisanSayisi; }

        private string Isim;
        
        private string Soyisim;

        private string Depertmant;


        static Calısan()
        {
            calisanSayisi=0;
        }


        public Calısan(string ısim, string soyisim, string depertmant)
        {
            this.Isim = ısim;
            this.Soyisim = soyisim;
            this.Depertmant = depertmant;
            calisanSayisi ++;
        }




    }

    static class Islemler
    {
        public static long Toplama(int sayi1, int sayi2)
        {
            return sayi1+sayi2;
        }

        public static long Cikarma(int sayi1, int sayi2)
        {
            return sayi1-sayi2;
        }


        
    }