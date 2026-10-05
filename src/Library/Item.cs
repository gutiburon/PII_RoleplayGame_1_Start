public class Item : IItem
{
    public string Name { get; set; }

    public Item(string name)
    {
        Name = name;
    }
}