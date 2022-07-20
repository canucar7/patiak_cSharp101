internal class Program
{
    private static void Main(string[] args)
    {

        Console.WriteLine("Atama ve islemli atama");
            //Atama ve islemli atama 
                int x=3;
                int y=3;
                Console.WriteLine(y);
                y=y+2;
                y+=2; 
                Console.WriteLine(y);
                y/=1;
                Console.WriteLine(y);
                x*=2;
                Console.WriteLine(x);
            Console.WriteLine("Mantiksal Operatorler");
                //Mantiksal Operatorler
                // || veya
                // && ve 
                // ! degil
                bool isSuccess=true;
                bool isCompleted=false;
                 
                if(isSuccess && isCompleted )//ifin altina {} parantezi birden fazla line kullanilacaksa yazariz yoksa gerek yok.
                    Console.WriteLine("perfect!");
                if(isSuccess || isCompleted )
                    Console.WriteLine("great!");
                if(isSuccess && !isCompleted )
                    Console.WriteLine("fine!");
            Console.WriteLine("Iliskisel Operatorler");
                //İlişkisel Operatorler
                // > < >= <= == != 
                int a=3; 
                int b=4;
                bool sonuc=a<b;
                Console.WriteLine(sonuc);
                sonuc=a>b;
                Console.WriteLine(sonuc);
                sonuc=a!=b;
                Console.WriteLine(sonuc);
                sonuc=a==b;
                Console.WriteLine(sonuc);
            Console.WriteLine("Aritmetik Operatorler");
            // Aritmetik operatorler
            // + - / *
              int sayi1=10;
              int sayi2=5;
              int sonuc1=sayi1/sayi2;
              Console.WriteLine(sonuc1);
              sonuc1=sayi1*sayi2;
              Console.WriteLine(sonuc1);
             sonuc1=sayi1-sayi2;
             Console.WriteLine(sonuc1);
             sonuc1=sayi1+sayi2;
             Console.WriteLine(sonuc1);
             sonuc1=sayi1*sayi2;
             Console.WriteLine(sonuc1);
             sonuc1=++sayi1; // sayi1++ de[er atandiktan sonra islem yapar bu sebeple sonucu 10 yapar ancak ++sayi1 artirip deger atar bu yuzden sonuc 11
             Console.WriteLine(sonuc1);
// % mod alir.Kalani bulur
            int sonuc2=20%3;
            Console.WriteLine(sonuc2);


    }
}