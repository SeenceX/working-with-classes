using task1;
using task2;

namespace L.R._1_23
{
    internal static class Program
    {
        public static void Main()
        {
            HumanGrowth hg = new HumanGrowth();
            hg.FillList();
            hg.PrintList();
            /* Prog - 2
            int[,] matrix = new int[5, 5];
            SwapMaxMin unit = new SwapMaxMin();
            unit.Matrix = matrix;
            unit.FillMatrix();
            unit.PrintMatrix();
            unit.Swap();
            unit.PrintMatrix();*/

            /* Prog - 1
            string number = Console.ReadLine();
            Palindrome palindrome = new Palindrome(number);
            palindrome.IsPalindrome();*/
        }
    }
}

/*
void second()
{
    int[,] matrix = new int[5, 5];
    Random random = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = random.Next(-20, 20);
        }
    }

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i,j] + " ");
        }
    }
    int max = -100, min = 100;
    int[] indexMax = new int[2];
    int[] indexMin = new int[2];
    

    for (int i = 0; i < matrix.GetLength(0); i++)
   {
       for (int j = 0; j < matrix.GetLength(1); j++)
       {
           if (i < j)
           {
               if (matrix[i, j] > max)
               {
                   max = matrix[i, j];
                   indexMax[0] = i;
                   indexMax[1] = j;
               }
           }
           if (i > j)
           {
               if (matrix[i, j] < min)
               {
                   min = matrix[i, j];
                   indexMin[0] = i;
                   indexMin[1] = j;
               }
           }
       }
   }
    
    matrix[indexMax[0], indexMax[1]] = min;
    matrix[indexMin[0], indexMin[1]] = max;
    Console.WriteLine($"\n\nmax = {max}, min = {min}\nindexMax = {indexMax[0]}|{indexMax[1]}\nindexMin = {indexMin[0]}|{indexMin[1]}\n");
    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i,j] + " ");
        }
    }
}
//second();

void third()
{
    List<Persons> list = new List<Persons>();
    list.Add(new Persons("Ivanov", 180));
    list.Add(new Persons("Andreev", 194));
    list.Add(new Persons("Vasilev", 174));
    list.Add(new Persons("Saharov", 168));
    list.Add(new Persons("Levedev", 183));
    list.Add(new Persons("Mihailov", 169));
    Console.WriteLine("Список:");
    list.ForEach(person => Console.
        WriteLine($"{person.getSecondName()} - {person.getHeight()}"));
    
    var avg = 0;
    foreach (var person in list)
    {
        avg += person.getHeight();
    }

    avg /= list.Count;
    Console.WriteLine($"{avg} - {list.Count}");
    Console.WriteLine($"Средний рост равен {avg}\n");
    Console.WriteLine("Удовлетворяют условию по росту");
    foreach (var person in list)
    {
        if (person.getHeight() >= avg)
            Console.WriteLine($"{person.getSecondName()} - {person.getHeight()}");
    }
}
third();



class First
{
    private int _input;
    private string _text;

    public First()
    {
        //
    }
    
}*/