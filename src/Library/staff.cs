public class Staff : IItemOffensive, IItemDefensive
{
    public string Name { get; }
    public int AttackValue { get; }
    public int DefenseValue { get; }

    public Staff(string name, int attackValue, int defenseValue)
    {
        Name = name;
        AttackValue = attackValue;
        DefenseValue = defenseValue;
    }
}