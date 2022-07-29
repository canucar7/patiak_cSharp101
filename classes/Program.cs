    internal class Program
    {
        private static void Main(string[] args)
        {
            Calısan calısan1 = new Calısan();
            calısan1.Ad="Murat";
            calısan1.Soyad="Kürkçü";
            calısan1.No=234561;
            calısan1.Depertmant="İnsan Kaynakları";
            calısan1.CalısanBilgileri();

            Console.WriteLine("*********");

            Calısan calısan2 = new Calısan();
            calısan2.Ad="Selin";
            calısan2.Soyad="Mutlu";
            calısan2.No=387162;
            calısan2.Depertmant="Satın Alma";
            calısan2.CalısanBilgileri();

            



        }
    }

    class Calısan
    {
        public string Ad;
        
        public string Soyad;

        public int No;

        public string Depertmant;

        public void CalısanBilgileri()
        {
            Console.WriteLine("Çalışanın Adı : {0}",Ad);
            Console.WriteLine("Çalışanın Soyadı : {0}",Soyad);
            Console.WriteLine("Çalışanın Numarası : {0}",No);
            Console.WriteLine("Çalışanın Depertmanı : {0}",Depertmant);
        }
    }