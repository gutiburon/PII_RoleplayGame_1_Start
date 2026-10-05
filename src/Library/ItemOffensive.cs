public class ItemOffensive : RegularItem, IItemOffensive
{
    public int AttackValue { get; set; }

    public ItemOffensive(string name, int attackValue) : base(name)
    {
        AttackValue = attackValue;
    }
}