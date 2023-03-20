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
            hg.PrintAboveAverage();
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