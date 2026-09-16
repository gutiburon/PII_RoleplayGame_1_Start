using System.Collections.Generic;

public class Dwarf : ICharacter
{
    public string Name { get; set; }
    public int AttackValue { get; set; }
    public int DefenseValue { get; set; }
    public int Health { get; set; }
    public bool IsMagic { get; }

    public IList<IItem> Items { get; } = new List<IItem>();

    public Dwarf(string name, int attackValue, int defenseValue, int health)
    {
        this.Name = name;
        this.AttackValue = attackValue;
        this.DefenseValue = defenseValue;
        this.Health = health;
        this.IsMagic = false;
    }

    public void AddItem(IItem item)
    {
        this.Items.Add(item);
    }

    public void RemoveItem(IItem item)
    {
        this.Items.Remove(item);
    }

    public void RecieveAttack(int attackValue)
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