using System.Collections.Generic;

public class Dwarf : Hero
{
    public Dwarf(string name, int attackValue, int defenseValue, int health)
        : base(name, attackValue, defenseValue, health)
    {
        IsMagic = false;
    }

    public bool IsMagic { get; private set; }
}