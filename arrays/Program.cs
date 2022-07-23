internal class Program
{
    private static void Main(string[] args)
    {

         string[] colors = new string[6];

         string[] animals = {"Dog","Cat","Horse","Donkey"};

         int[] arr;
         arr = new int[4];


         colors[0] = "Blue";
         arr[3] = 8;

         Console.WriteLine(animals[1]);
         Console.WriteLine(colors[0]);
         Console.WriteLine(arr[3]);



         Console.Write("Lütfen bir sayı giriniz : ");
         int number = int.Parse(Console.ReadLine());

         int[] numbers = new int[number];

         for (int i = 0; i < numbers.Length; i++)
         {
            Console.Write("Lütfen {0}. sayıyı giriniz : " ,i+1);
            int sayi = int.Parse(Console.ReadLine());
            numbers[i] = sayi;

         }

         int sum =0;

         foreach (var sayi in numbers)
         {
            sum +=sayi;
         }         

        Console.WriteLine("Ortalama : " + sum/number);



    }
}