public class Sword : IItemOffensive
{
    public string Name { get; }
    public int AttackValue { get; }

    public Sword(string name, int attackValue)
    {
        Name = name;
        AttackValue = attackValue;
    }
}