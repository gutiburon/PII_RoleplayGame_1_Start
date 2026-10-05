public class Axe : IItemOffensive
{
    public string Name { get; }
    public int AttackValue { get; }

    public Axe(string name, int attackValue)
    {
        Name = name;
        AttackValue = attackValue;
    }
}