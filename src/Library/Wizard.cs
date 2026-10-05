using System;
namespace Library
{
   public class Wizard : Hero
{
    public Wizard(string name, int attackValue, int defenseValue, int health)
        : base(name, attackValue, defenseValue, health)
    {
        IsMagic = true;
    }

    public bool IsMagic { get; private set; }
}
}
