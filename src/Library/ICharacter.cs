public interface ICharacter
{
    string Name { get; set; }
    int AttackValue { get; set; }
    int DefenseValue { get; set; }
    int Health { get; set; }
    
    bool IsMagic { get;}

    IList<IItem> Items { get;}
    
    void AddItem(IItem item);
    void RemoveItem(IItem item);


    void RecieveAttack(int attackValue);
    void Heal(int healValue);
}
