using System.ComponentModel;

namespace Library;

public class Spell : IItem, IItemOffensive, IItemDefensive
{
    public string Name { get; set; }
    public int AttackValue { get; set; }
    public int DefenseValue { get; set; }
}