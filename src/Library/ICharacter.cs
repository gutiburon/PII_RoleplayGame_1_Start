public interface ICharacter
{
    string Name { get; set; }
    int AttackValue { get; set; }
    int DefenseValue { get; set; }
    int Health { get; set; }

    IList<IOffensiveItem> OffensiveItems { get;}
    IList<IDefensiveItem> DefensiveItems { get;}
    
    void AddOffensiveItem(IOffensiveItem item);
    void AddDefensiveItem(IDefensiveItem item);
    void RemoveOffensiveItem(IOffensiveItem item);
    void RemoveDefensiveItem(IDefensiveItem item);


    void RecieveAttack(int attackValue);
    void Heal(int healValue);
}
