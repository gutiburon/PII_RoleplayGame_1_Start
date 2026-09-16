public class Armor : IItemDefensive
{
    public string Name { get; }
    public int DefenseValue { get; }

    public Armor(string name, int defenseValue)
    {
        Name = name;
        DefenseValue = defenseValue;
    }
}