namespace menu;
using task1;
using task2;
using task3;

public class Menu
{
    private void PrintMenu()
    {
        Console.WriteLine("Выберите программу для запуска:");
        Console.WriteLine("1 - Программа 1");
        Console.WriteLine("2 - Программа 2");
        Console.WriteLine("3 - Программа 3");
        Console.WriteLine("0 - Выход");
    }

    private string InputCommand()
    {
        Console.Write("Введите номер программы: ");
        string input = Console.ReadLine();
        return input;
    }
    
    public void Start()
    {
        bool exit = false;
        while (!exit)
        {
            
            PrintMenu();
            string input = InputCommand();
            int programNumber;

            if (int.TryParse(input, out programNumber))
            {
                switch (programNumber)
                {
                    case 0:
                        exit = true;
                        break;

                    case 1:
                        Palindrome palindrome = new Palindrome();
                        palindrome.IsPalindrome();
                        break;

                    case 2:
                        int[,] matrix = new int[5, 5];
                        SwapMaxMin unit = new SwapMaxMin();
                        unit.Matrix = matrix;
                        unit.FillMatrix();
                        unit.PrintMatrix();
                        unit.Swap();
                        unit.PrintMatrix();
                        break;

                    case 3:
                        HumanGrowth hg = new HumanGrowth();
                        hg.FillList();
                        hg.PrintList();
                        hg.PrintAboveAverage();
                        break;

                    default:
                        Console.WriteLine("Некорректный номер программы.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Некорректный ввод. Введите номер программы от 0 до 3.");
            }
            Console.WriteLine();
        }
    }
}