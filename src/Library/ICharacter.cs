public interface ICharacter
{
    string Name { get; set; }
    int AttackValue { get; set; }
    int DefenseValue { get; set; }
    int Health { get; set; }

    IList<IItemOffensive> OffensiveItems { get;}
    IList<IItemDefensive> DefensiveItems { get;}
    
    void AddOffensiveItem(IItemOffensive item);
    void AddDefensiveItem(IItemDefensive item);
    void RemoveOffensiveItem(IItemOffensive item);
    void RemoveDefensiveItem(IItemDefensive item);


    void RecieveAttack(int attackValue);
    void Heal(int healValue);
}
