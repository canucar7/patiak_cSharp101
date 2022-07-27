internal class Program
{
    private static void Main(string[] args)
    {
        string degisken = "Dersimiz Csharp, Hoşgeldiniz";
        string degisken2 = " Csharp";

        Console.WriteLine(degisken.Length);

        Console.WriteLine(degisken.ToUpper());
        Console.WriteLine(degisken.ToLower());

        Console.WriteLine(String.Concat(degisken,"Merhaba"));


        Console.WriteLine(degisken.CompareTo(degisken2));
        Console.WriteLine(String.Compare(degisken,degisken2,true));
        Console.WriteLine(String.Compare(degisken,degisken2,false));


        Console.WriteLine(degisken.Contains(degisken2));
        Console.WriteLine(degisken.EndsWith("Hoşgeldiniz"));
        Console.WriteLine(degisken.StartsWith("Merhaba"));


        Console.WriteLine(degisken.IndexOf("Cs"));
        Console.WriteLine(degisken.IndexOf("Can"));
        Console.WriteLine(degisken.LastIndexOf("i"));


        Console.WriteLine(degisken.Insert(0, "Merhaba! "));


        Console.WriteLine(degisken + degisken2.PadLeft(30));
        Console.WriteLine(degisken + degisken2.PadLeft(30,'*'));
        Console.WriteLine(degisken.PadRight(50) + degisken2);
        Console.WriteLine(degisken.PadRight(50,'-') + degisken2);


        Console.WriteLine(degisken.Remove(10));
        Console.WriteLine(degisken.Remove(5,3));
        Console.WriteLine(degisken.Remove(0,1));


        Console.WriteLine(degisken.Replace("Csharp","C#"));
        Console.WriteLine(degisken.Replace(" ","*"));


        Console.WriteLine(degisken.Split(' ')[1]);


        Console.WriteLine(degisken.Substring(4));
        Console.WriteLine(degisken.Substring(4,6));

























    

        



        



    }
}