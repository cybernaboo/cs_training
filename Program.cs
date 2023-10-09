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
        int[] result = new int[(myArray.Length)];
        for (int i = 0; i < myArray.Length; i++)
        {
            result[i] = myArray[i] * 2;
        }
        return result;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("J'additionne 2 nombres : " + Add(3, 4));
        Console.WriteLine("Factorielle de 5 : " + Factorielle(5));
        int[] localArray = new int[] { 0, 2, 4 };
        Console.WriteLine("Tableau doublé en valeurs : 0-2-4 => " + DoubleArrayValues(localArray)[0] + +DoubleArrayValues(localArray)[1] + +DoubleArrayValues(localArray)[2]);
    }
}

