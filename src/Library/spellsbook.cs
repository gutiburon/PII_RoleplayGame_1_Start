using System.Collections;
using System.Collections.Generic;

namespace Library;

public class SpellsBook : ISpellsbook
{
    public ICollection<Spell> Spells { get; }

    public int AttackValue { get; set; }

    public int DefenseValue { get; set; }

    public SpellsBook()
    {
        Spells = new List<Spell>();
    }
}