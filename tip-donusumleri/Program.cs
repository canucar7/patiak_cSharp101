internal class Program
{
    private static void Main(string[] args)
    {
        byte a=5;
        sbyte b=30;
        short c=10;
        int d=a+b+c;
        Console.WriteLine("d:" + d);
        long h=d;
        Console.WriteLine("h:" + h);
        float i=h;
        Console.WriteLine("i:" + i);
        string e="can";
        char f= 'k';
        object g= e+f+d;
        Console.WriteLine("g:" + g);
    }
}