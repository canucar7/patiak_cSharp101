    internal class Program
    {
        private static void Main(string[] args)
        {
            string sayi = "888";
            
            bool sonuc = int.TryParse(sayi,out int outSayi);
            if (sonuc)
            {
                Console.WriteLine("Başarılı ");
                Console.WriteLine(outSayi);
            }
            else
            {
                Console.WriteLine("Başarısız ");
            }

            Method inst = new Method();
            inst.Topla(7,8,out int toplamSonuc);
            Console.WriteLine(toplamSonuc);


            int ifade = 99;
            inst.ekranaYazdir(Convert.ToString(ifade));
            inst.ekranaYazdir(ifade);
            inst.ekranaYazdir("ali","efe");



        }
    }

    class Method
    {
        public void Topla(int a, int b, out int toplam)
        {
            toplam=a+b;
        }

        public void ekranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }

        public void ekranaYazdir(int veri)
        {
            Console.WriteLine(veri);
        }

        public void ekranaYazdir(string veri1 , string ver2)
        {
            Console.WriteLine(veri1 + ver2);
        }



    }