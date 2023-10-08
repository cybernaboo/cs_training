using System.Formats.Asn1;

public class Program
{
    static int Add(int a, int b)
    {
        return a + b;
    }

    static int Factorielle(int a)
    {
        int result = 1;
        for (int i = 1; i <= a; i++)
        {
            result = result * i;
        }
        return result;
    }
    static int[] DoubleArrayValues(int[] myArray)
    {
        int[] result = int[]
        for (int i = 1; i <= a; i++)
        {
            result = result * i;
        }
        return result;
    }
    static void Main(string[] args)
    {
        Console.WriteLine("J'additionne 2 nombres : " + Add(3, 4));
        Console.WriteLine("Factorielle de 5 : " + Factorielle(5));
    }
}

