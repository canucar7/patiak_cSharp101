internal class Program
{
    private static void Main(string[] args)
    {
        int a = 6;
        int b = 4;
        Console.WriteLine(a+b);

        int sonuc = Topla(a,b);
        Console.WriteLine(sonuc);

        Method ornek = new Method();
        ornek.EkranaYazdir(Convert.ToString(sonuc));


        int sonuc2 = ornek.ArttırVeTopla(ref a,ref b);
        ornek.EkranaYazdir(Convert.ToString(sonuc2));
        ornek.EkranaYazdir(Convert.ToString(a+b));



    }


    static int Topla(int deger1, int deger2)
    {
        return deger1+deger2;
    }
}

class Method
{
    public void EkranaYazdir(string veri)
    {
        Console.WriteLine(veri);
    }


    public int ArttırVeTopla(ref int deger1 , ref int deger2)
    {
        deger1++;
        deger2++;
        return deger1+deger2;
    }




}