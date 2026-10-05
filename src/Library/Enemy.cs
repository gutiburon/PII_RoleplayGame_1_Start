public class Enemy : Character
{
    public int VictoryPoints { get; }

    public Enemy(string name, int attackValue, int defenseValue, int health, int victoryPoints)
        : base(name, attackValue, defenseValue, health)
    {
        VictoryPoints = victoryPoints;
    }
}