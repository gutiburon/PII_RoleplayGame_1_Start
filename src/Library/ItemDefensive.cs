public class ItemDefensive : RegularItem, IItemDefensive
{
    public int DefenseValue { get; }

    public ItemDefensive(string name, int defenseValue) : base(name)
    {
        DefenseValue = defenseValue;
    }
}