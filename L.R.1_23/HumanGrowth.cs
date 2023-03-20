namespace task3;
using persons;

public class HumanGrowth
{
    private List<Persons> _list;
    
    public void FillList()
    {
        _list = new List<Persons>();
        Random rand = new Random();
        //rand.Next(-20, 20);
        for (int i = 1; i < 11; i++)
        {
            _list.Add(new Persons($"Person #{i}", rand.Next(160, 200)));
        }
    }

    public void PrintList()
    {
        _list.ForEach(person => Console.
            WriteLine($"{person.getSecondName()} - {person.getHeight()}"));
    }

    public void PrintAboveAverage()
    {
        var avg = FindAvgHeight();
        Console.WriteLine($"Средний рост равен {avg}\n");
        Console.WriteLine("Удовлетворяют условию по росту");
        foreach (var person in _list)
        {
            if (person.getHeight() >= avg)
                Console.WriteLine($"{person.getSecondName()} - {person.getHeight()}");
        }
    }
    private int FindAvgHeight()
    {
        var avg = 0;
        foreach (var person in _list)
        {
            avg += person.getHeight();
        }
        avg /= _list.Count;
        return avg;
    }
}