internal class Program
{
    private static void Main(string[] args)
    {

        /*
        Console.WriteLine("Bir sayi giriniz : ");
        int num = int.Parse(Console.ReadLine());

        int count = 1;
        int sum = 0;

        while (count <= num)
        {
            sum += count ;
            count ++ ;
        }

        Console.WriteLine(sum/num);
        */


        char ch = 'a';
        while (ch < 'z')
        {
            Console.Write(ch);
            ch ++ ;
        }

        Console.WriteLine(" ");

        string[] cars = {"BMW", "Mercedes" , "Audi", "Nissan"};
        foreach (var car in cars)
        {
            Console.WriteLine(car);
        }

    }
}