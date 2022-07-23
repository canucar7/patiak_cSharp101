internal class Program
{
    private static void Main(string[] args)
    {
        int[] sayiDizisi = {23,12,4,86,72,3,11,17};

        foreach (var sayi in sayiDizisi)
            Console.WriteLine(sayi);
     

        Console.WriteLine("*********");


        Array.Sort(sayiDizisi);
        foreach (var sayi in sayiDizisi)
            Console.WriteLine(sayi);
        

        Console.WriteLine("*********");


        Array.Clear(sayiDizisi,3,3);
        foreach (var sayi in sayiDizisi)
            Console.WriteLine(sayi);


         Console.WriteLine("*********");    

         Array.Reverse(sayiDizisi);
          foreach (var sayi in sayiDizisi)
            Console.WriteLine(sayi);



        Console.WriteLine("*********");  

        Console.WriteLine(Array.IndexOf(sayiDizisi,11));


        Console.WriteLine("*********");  
        Array.Resize<int>(ref sayiDizisi,9);

        sayiDizisi[8] = 99;
        foreach (var sayi in sayiDizisi)
            Console.WriteLine(sayi);






    }
}