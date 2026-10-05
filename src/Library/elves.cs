using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;
using System.Runtime.CompilerServices;

public class Elves : ICharacter
{
    public string Name
    {
        {get; set;}
    }
    public int Health
    {
        {get; set;}
    }
    
    public int AttackValue
    {
        {get; set;}
    }
    public int DefenseValue
    {
        {get; set;}
    }
    public bool IsMagic
    {
        {get;}
    }

    public IList<IItem> Items {get; } = new List<IItem>();

    public Elves(string name, int health, int attackValue, int defenseValue, bool isMagic)
    {
        this.Name = name;
        this.Health = health;
        this.AttackValue = attackValue;
        this.DefenseValue = defenseValue;
        this.IsMagic = false;
    }

    public void RecieveAttack(int attackValue)
    {
        int damage = attackValue = this.DefenseValue;
        if (damage > 0)
        {
            this.Health -= damage;
        }
    }
    public void Heal()
    {
        this.Health += healValue;
    }
    public void AddItem(IItem item)
    {
        this.Items.Add(item);
    }
    public void RemoveItem(IItem item)
    {
        this.Items.Remove(item);
    }
}