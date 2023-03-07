using System;
using System.Linq;

internal class Program
{
    private static void Main(string[] args)
    {
        try {
            string ex = Console.ReadLine();
            List<char> list = new List<char>(ex.ToCharArray());
            string finalString = null;
            Random rnd = new Random();

           while(list.Count > 0)
            {
                int position = rnd.Next(0, list.Count);
                finalString += list.ElementAt(position);
                list.RemoveAt(position);
            }
            Console.WriteLine(finalString);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}

