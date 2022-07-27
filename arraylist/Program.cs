using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        ArrayList list = new ArrayList();
        /*list.Add("Memo");
        list.Add(2);
        list.Add(true);
        list.Add('A');

        Console.WriteLine(list[1]);

        foreach (var item in list)
        {
              Console.WriteLine(item);  
        }*/

        //AddRange

        Console.WriteLine("***addrange***");
        //string[] renkler = {"kırmızı","yeşil","mavi"};
        List<int> sayılar = new List<int>(){1,8,6,4,3,2};

        //list.AddRange(renkler);
        list.AddRange(sayılar);

         foreach (var item in list)
        {
              Console.WriteLine(item);  
        }


        //Sort
        Console.WriteLine("****Sort******");  
        list.Sort();
        
        foreach (var item in list)
        {
              Console.WriteLine(item);  
        }

        //Binary search
        Console.WriteLine("****Binary search******"); 
        Console.WriteLine(list.BinarySearch(4)); 


        //Reverse
        Console.WriteLine("****Reverse******"); 
        list.Reverse();
        foreach (var item in list)
        {
              Console.WriteLine(item);  
        }


        //Clear
        Console.WriteLine("****Clear******"); 
        list.Clear();
        foreach (var item in list)
        {
              Console.WriteLine(item);  
        }


         
        
        
    }
}