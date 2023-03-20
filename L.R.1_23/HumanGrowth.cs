namespace L.R._1_23;

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
}


/*
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
 */