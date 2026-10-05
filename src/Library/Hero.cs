public class Hero : Character
{
    public int VictoryPoints { get; private set; }

    public Hero(string name, int attackValue, int defenseValue, int health)
        : base(name, attackValue, defenseValue, health)
    {
    }

    public void Defeat(Enemy enemy)
    {
        VictoryPoints += enemy.VictoryPoints;

        if (VictoryPoints >= 5)
        {
            Heal(5);
        }
    }

    public void Heal(int amount)
    {
        Health += amount;
    }