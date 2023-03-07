using System;
using System.Linq;

internal class Program
{
    private static void Main(string[] args)
    {
        try { 
        List<int> sequence = new List<int> { 0, 1};
        int number = int.Parse(Console.ReadLine());
        int[] seq = new int[] {0,1 };

        while(sequence.Max() < number)
        {
            int next;
            next = seq[0] + seq[1];
            sequence.Add(next);
            seq[0] = seq[1];
            seq[1] = next;
        }
        Console.WriteLine(sequence.Contains(number));

        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}

