    internal class Program
    {
        private static void Main(string[] args)
        {

            int result =1;
            for (int i = 1; i < 5; i++)
            {
                result = result *3;
            }
            Console.WriteLine(result);


            Islemler inst = new();
            Console.WriteLine(inst.Expo(3,4));

            //Extension methodlar
            string ifade = "Şükrü Can UÇAR";
            bool sonuc = ifade.CheckSpaces();
            Console.WriteLine(sonuc);
            if (true)
            {
               Console.WriteLine(ifade.RemoveWhiteSpaces()); 
            }


            Console.WriteLine(ifade.MakeUpperCase());
            Console.WriteLine(ifade.MakeLowerCase());

            int[] dizi2 = {9,3,6,4,7,1,2};
            dizi2.SortArray();
            dizi2.WriteScreen();

            int sayi = 5;
            Console.WriteLine(sayi.IsEvenNumber());


            Console.WriteLine(ifade.GetFirstCharacter());




        
            
        
        }
    }


    public class Islemler
    {
        public int Expo(int sayi , int üs)
        {
            if(üs<2)
                return sayi;

            return Expo(sayi,üs-1)+sayi;    
        }


    }


    public static class Extension
    {
        public static bool CheckSpaces(this string param)
        {
            return param.Contains(" ");
        }


        public static string RemoveWhiteSpaces(this string param)
        {
            string[] dizi = param.Split(" ");
            return string.Join("",dizi); 
        }


        public static string MakeUpperCase(this string param)
        {
            return param.ToUpper();
        }

        public static string MakeLowerCase(this string param)
        {
            return param.ToLower();
        }


        public static int[] SortArray(this int[] param)
        {
            Array.Sort(param);
            return param;
        }

        public static void WriteScreen(this int[] param)
        {
            foreach (int item in param)
                Console.WriteLine(item);
        }


        public static bool IsEvenNumber(this int param)
        {
            return param%2==0;

        }


        public static string GetFirstCharacter(this string param)
        {
            return param.Substring(0,1);
        }
        
        
    }