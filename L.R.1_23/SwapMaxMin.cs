namespace task2;

public class SwapMaxMin
{
    private int[,] _matrix;

    public int[,] Matrix
    {
        get => _matrix;
        set => _matrix = value;
    }
    public void FillMatrix()
    {
        Random rand = new Random();
        for (int i = 0; i < _matrix.GetLength(0); i++)
        {
            for (int j = 0; j < _matrix.GetLength(1); j++)
            {
                _matrix[i, j] = rand.Next(-20, 20);
            }
        }
    }
    public void PrintMatrix()
    {
        for (int i = 0; i < _matrix.GetLength(0); i++)
        {
            Console.WriteLine();
            for (int j = 0; j < _matrix.GetLength(1); j++)
            {
                Console.Write(String.Format("{0,4}", _matrix[i,j] + " "));
            }
        }
    }

    public void Swap()
    {
        int[][] indexes = new int[2][];
        indexes = FindIndexes();
        Console.WriteLine();
        int max = _matrix[indexes[0][0], indexes[0][1]];
        int min = _matrix[indexes[1][0], indexes[1][1]];
        
        Console.WriteLine($"MAX - {max} with indexes: {indexes[0][0]}, {indexes[0][1]}\n" +
                          $"MIN - {min} with indexes: {indexes[1][0]}, {indexes[1][1]}");

        Console.WriteLine("\nSwaping...");
        
        _matrix[indexes[0][0], indexes[0][1]] = min;
        _matrix[indexes[1][0], indexes[1][1]] = max;
    }

    private int[][] FindIndexes()
    {
        int max = -21, min = 21;
        List<int[]> valuesList = new List<int[]>();

        int[] indexMax = new int[2];
        int[] indexMin = new int[2];
    

        for (int i = 0; i < _matrix.GetLength(0); i++)
        {
            for (int j = 0; j < _matrix.GetLength(1); j++)
            {
                if (i < j)
                {
                    if (_matrix[i, j] > max)
                    {
                        max = _matrix[i, j];
                        indexMax[0] = i;
                        indexMax[1] = j;
                    }
                }
                if (i > j)
                {
                    if (_matrix[i, j] < min)
                    {
                        min = _matrix[i, j];
                        indexMin[0] = i;
                        indexMin[1] = j;
                    }
                }
            }
        }

        valuesList.Add(indexMax);
        
        valuesList.Add(indexMin);
        int[][] values = valuesList.ToArray();

        return values;
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
}*/