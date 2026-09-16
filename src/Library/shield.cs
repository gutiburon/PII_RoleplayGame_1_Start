public class Shield : IItemDefensive
{
    public string Name { get; }
    public int DefenseValue { get; }

    public Shield(string name, int defenseValue)
    {
        Name = name;
        DefenseValue = defenseValue;
    }
}