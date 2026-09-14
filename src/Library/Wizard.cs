using System;
namespace Library
{
    public class Wizard
    {
        private string name;
        public string Name
        {
            get {return name;} set {name = value;}
        }
        private int attackValue;
        public int AttackValue
        {
            get {return attackValue;} set {attackValue = value;}
        }
        private int defenseValue;
        public int DefenseValue
        {
            get {return defenseValue;} set {defenseValue = value;}
        }
        private int health;
        public int Health
        {
            get {return health;} set {health = value;}
        }
        private Staff staff;
        public Staff Staff
        {
            get {return staff;} set {staff = value;}
        }
        private SpellsBook spellsBook;
        public SpellsBook SpellsBook
        {
            get {return spellsBook;} set {spellsBook = value;}
        }
        public Wizard(string name, int attackValue, int defenseValue, int health, SpellsBook spellsBook, Staff staff)
        {
            this.name = name;
            this.attackValue = attackValue;
            this.defenseValue = defenseValue;
            this.health = health;
            this.spellsBook = spellsBook;
            this.staff = staff;
        }
        public void Attack(SpellsBook spellsBook, Staff staff)
        {
            
        }
        public void ReceiveAttack(SpellsBook spellsBook, Staff staff, )
        {
            
        }
    }
}
