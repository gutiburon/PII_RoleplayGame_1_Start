using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;
using System.Runtime.CompilerServices;

public class Elves : Hero
{

    public Elves(string name, int attackValue, int defenseValue, int health)
        : base(name, attackValue, defenseValue, health)
    {
        IsMagic = false;
    }

    public bool IsMagic { get; private set; }
    }
