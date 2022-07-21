internal class Program
{
    private static void Main(string[] args)
    {
       
        int time = DateTime.Now.Hour;
        Console.WriteLine("Saat: " + time);
        
        if (time >= 6 && time < 12 )
        {
            Console.WriteLine("Günaydın ");
        }
        else if(time <=18)
        {
            Console.WriteLine("İyi günler ");
        }
        else
        {
            Console.WriteLine("İyi akşamlar ");
        }


        string str = time <= 18 ? "İyi günler " : "İyi akşamlar" ;
        Console.WriteLine(str);

        string srr = time >=6 && time <12 ? "Günaydın" : time <18 ? "İyi günler " : "İyi akşamlar";
        Console.WriteLine(str);



    }
}