    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("*****Çalışan 1 ****");
            Calısan calısan1 = new Calısan("Murat", "Kürkçü",234561,"İnsan Kaynakları");
            calısan1.CalısanBilgileri();

            Console.WriteLine("*****Çalışan 2 ****");    
            Calısan calısan2 = new Calısan();
            calısan2.Ad="Selin";
            calısan2.Soyad="Mutlu";
            calısan2.No=387162;
            calısan2.Depertmant="Satın Alma";
            calısan2.CalısanBilgileri();

            Console.WriteLine("*****Çalışan 3 ****");
            Calısan calısan3 = new Calısan("Ahmet", "Kaya");
            calısan3.CalısanBilgileri();  
            
                  




            
        }
    }

     class Calısan
    {
        public string Ad;
        
        public string Soyad;

        public int No;

        public string Depertmant;

        
        public Calısan(string ad , string soyad , int no, string depertmant)
        {
            this.Ad=ad;
            this.Soyad=soyad;
            this.No=no;
            this.Depertmant=depertmant;
        }

        public Calısan(){}



        public Calısan(string ad, string soyad)
        {
            this.Ad=ad;
            this.Soyad=soyad;
        }
        

        public void CalısanBilgileri()
        {
            Console.WriteLine("Çalışanın Adı : {0}",Ad);
            Console.WriteLine("Çalışanın Soyadı : {0}",Soyad);
            Console.WriteLine("Çalışanın Numarası : {0}",No);
            Console.WriteLine("Çalışanın Depertmanı : {0}",Depertmant);
        }
    }