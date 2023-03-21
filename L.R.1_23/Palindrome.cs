namespace task1;

public class Palindrome
{
    private string _x;
    public Palindrome()
    {
        _x = inputNumber();
    }

    public bool IsPalindrome()
    {
        int input = CheckNumber();
        string str = Convert.ToString(input);
        string rStr = string.Empty;
        for (int i = str.Length - 1; i >= 0; i--)
            rStr += str[i];

        if (str == rStr)
        {
            Console.WriteLine($"Число {str}- палиндром");
            return true;
        }else
        {
            Console.WriteLine($"Число {str} - не палиндром");
            return false;
        }
    }

    private string inputNumber()
    {
        Console.Write("Введите число: ");
        return Console.ReadLine();
    }

    private int CheckNumber()
    {
        string text = _x;
        
        while (true)
        {
            if (int.TryParse(text, out int innerNumber)) //tryParse возвращает успешно ли выполнено преобразование
            {
                if (innerNumber > 0)
                {
                    if (text.Length >= 5)
                    {
                        return innerNumber;
                    }
                    Console.WriteLine("В числе меньше 5 разрядов, попробуйте еще раз.");
                    text = inputNumber();
                    continue;
                }
                Console.WriteLine("Число не положительное, попробуйте еще раз.");
                text = inputNumber();
                continue;
            }
            Console.WriteLine("Не удалось распознать число, попробуйте еще раз.");
            text = inputNumber();
        }
    }
}
