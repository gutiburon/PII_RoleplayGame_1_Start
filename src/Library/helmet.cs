public class Helmet : IItemDefensive
{
    public string Name { get; }
    public int DefenseValue { get; }

    public Helmet(string name, int defenseValue)
    {
        Name = name;
        DefenseValue = defenseValue;
    }
}