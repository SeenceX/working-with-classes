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
        Console.WriteLine();
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