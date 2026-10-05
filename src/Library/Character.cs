using System.Runtime.CompilerServices;

public abstract class Character
{
    private string name;
    private int attackValue;
    private int defenseValue;
    private int health;
    private bool isMagic;
    private IList<IItem> items;

    public string Name
    {
        get {return this.name;} set {this.name = value;}
    }
    public int AttackValue
    {
        get {return this.attackValue;} set {this.attackValue = value;}
    }
    public int DefenseValue
    {
        get {return this.defenseValue;} set {this.defenseValue = value;}
    }
    public int Health
    {
        get {return this.health;} set {this.health = value;}
    }
    
    public bool IsMagic
    {
        get {return this.isMagic;} set {this.isMagic = value;}
    }
    public IList<IItem> Items
    {
        get { return this.items; }
    }
    public Character(string name, int attackValue, int defenseValue, int health, bool isMagic)
    {
        this.name = name;
        this.attackValue = attackValue;
        this.defenseValue = defenseValue;
        this.health = health;
        this.isMagic = isMagic;
        this.items = new List<IItem>();
    }
    
    public void AddItem(IItem item)
    {
        this.items.Add(item);
    }
    public void RemoveItem(IItem item)
    {
        this.items.Remove(item);
    }


    public void ReceiveAttack(int attackValue)
    {
        int damage = attackValue - this.DefenseValue;
        if (damage > 0)
        {
            this.Health -= damage;
        }
    }
    public void Heal(int healValue)
    {
        this.Health += healValue;
    }
}
