internal class Program
{
    private static void Main(string[] args)
    {
        /*
        Console.WriteLine("Bir sayi giriniz : ");
        int num = int.Parse(Console.ReadLine());

        for (int i = 0; i <= num; i++)
        {
            if (num%2 ==1 )
            {
                Console.WriteLine(i);
            
            }
        }*/


        /*
        int tekToplam=0;
        int ciftToplam=0;
        for (int i = 1; i <= 1000; i++)
        {
            if (i%2 == 0)
            {
                ciftToplam +=i;
            }
            else
            {
                tekToplam +=i;
            }
        }

        Console.WriteLine("Çift sayiların toplamı : " + ciftToplam);
        Console.WriteLine("Tek sayiların toplamı : " + tekToplam);
        */


        for (int i = 0; i < 10; i++)
        {
            if (i==4)
                break;
            Console.WriteLine(i);    
        }

        Console.WriteLine("------"); 

         for (int i = 0; i < 10; i++)
        {
            if (i==4)
                continue;
            Console.WriteLine(i);    
        }

    }
}