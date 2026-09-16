using System.Collections;
namespace Library;

public interface ISpellsbook
{
    ICollection<Spell> Spells { get; }
    int AttackValue { get; }
    int DefenseValue { get; }
}