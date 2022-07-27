    internal class Program
    {
        private static void Main(string[] args)
        {

            List<int> sayiListesi = new List<int>();

            sayiListesi.Add(23);
            sayiListesi.Add(10);
            sayiListesi.Add(4);
            sayiListesi.Add(5);
            sayiListesi.Add(92);
            sayiListesi.Add(34);

            List<string> renkListesi = new List<string>();

            renkListesi.Add("Kırmızı");
            renkListesi.Add("Mavi");
            renkListesi.Add("Turuncu");
            renkListesi.Add("Sarı");
            renkListesi.Add("Yeşil");

            //Count
            Console.WriteLine(sayiListesi.Count);
            Console.WriteLine(renkListesi.Count);


            //Foreach
            foreach (var sayi in sayiListesi)
            {
                Console.WriteLine(sayi);
            }

            foreach (var renk in renkListesi)
            {
                Console.WriteLine(renk);
            }

            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));


            //Remove
            sayiListesi.Remove(4);
            renkListesi.Remove("Yeşil");

            sayiListesi.RemoveAt(0);
            renkListesi.RemoveAt(1);

            
            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));


            //Contains
            if (sayiListesi.Contains(10))
                Console.WriteLine("10 elemanı listede");


        //Elemenlarla indexe erişme
        Console.WriteLine(renkListesi.BinarySearch("Turuncu"));


        //Diziyi Liste çevirme
        string[] hayvanlar ={"Kedi" , "Köpek", "Kuş"};
        List<string> hayvanListesi = new List<string>(hayvanlar); 

        //Listeyi temizleme
        hayvanListesi.Clear();

        //List içerisinde nesne tutmak
        List<Kullanıcılar> kullanıcılarListesi = new List<Kullanıcılar>();
        Kullanıcılar kullanıcı1 = new Kullanıcılar();
        kullanıcı1.Isim="Fuat";
        kullanıcı1.Soyisim="Mert";
        kullanıcı1.Yas=23;

        Kullanıcılar kullanıcı2 = new Kullanıcılar();
        kullanıcı2.Isim="Hayriye";
        kullanıcı2.Soyisim="Yılmaz";
        kullanıcı2.Yas=18;

        kullanıcılarListesi.Add(kullanıcı1);
        kullanıcılarListesi.Add(kullanıcı2);

        List<Kullanıcılar> yeniListe = new List<Kullanıcılar>();

        yeniListe.Add(new Kullanıcılar(){
            Isim = "Mert",
            Soyisim ="Öztürk",
            Yas = 25
        });

        foreach (var kullanıcı in kullanıcılarListesi)
        {
            Console.WriteLine("Kullanıcı Adı : " + kullanıcı.Isim);
            Console.WriteLine("Kullanıcı Soyadı : " + kullanıcı.Soyisim);
            Console.WriteLine("Kullanıcı Yaş : " + kullanıcı.Yas);
            Console.WriteLine("  ");
        }

        yeniListe.Clear();




        }
    }
      

    public class Kullanıcılar{
        private string isim;

        private string soyisim;

        private int yas;

        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int Yas { get => yas; set => yas = value; }
    }



