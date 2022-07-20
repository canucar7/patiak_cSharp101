internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Bir sayı giriniz : ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Girmiş olduğunuz sayi :" + sayi);
        }
        catch(Exception ex){
            Console.WriteLine("Hata: " +ex.Message.ToString());
        }
        finally
        {
            Console.WriteLine("İşlem devam. ");
        }


        try
        {
            //int a = int.Parse(null);
            //int b = int.Parse("test");
            int c = int.Parse("-2000000000000");

        }
        catch (ArgumentNullException ex )
        {
            Console.WriteLine("Boş değer girdiniz  ");
            Console.WriteLine(ex);
        }
        catch(FormatException ex)
        {
            Console.WriteLine("Yanlış veri tipi girdiniz  ");
            Console.WriteLine(ex);
        }
        catch(OverflowException ex)
        {
            Console.WriteLine("Çok büyük ya da çok küçük bir değer girdnizi  ");
            Console.WriteLine(ex);
        }
        finally
        {
             Console.WriteLine("İşlem tamam");
        }



    }
}