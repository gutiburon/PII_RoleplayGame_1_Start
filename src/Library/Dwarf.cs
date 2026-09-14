public class Dwarf
{
    private string name;
    private int health;
    private int attackValue;
    private int defenseValue;
    private Helmet helmet;
    private Axe axe;
    private Shield shield;
     
     public Dwarf(string name, int health, int attackValue, int defenseValue, Helmet helmet, Axe axe, Shield shield)
    {
        this.name = name;
        this.health = health;
        this.attackValue = attackValue;
        this.defenseValue = defenseValue;
        this.helmet = helmet;
        this.axe = axe;
        this.shield = shield;
    }
   
   public void Attack(Axe axe)
    {
        
    }
    public void RecieveAttack(Helmet helmet, Shield shield, Wizard wizard, Elf elf, Dwarf dwarf)
    {
        
    }
}