namespace persons;

public class Persons
{
    private string _secondName;
    private int _height;
    
    public Persons(string secondName, int height)
    {
        _secondName = secondName;
        _height = height;
    }

    public int getHeight()
    {
        return _height;
    }

    public string getSecondName()
    {
        return _secondName;
    }
}