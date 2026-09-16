public class Elves
{
    private string name;
    private int health;
    private int attackValue;
    public int AttackValue
    {
        {get : return attackValue; }
    }
    private int DefenseValue;
    public int defenseValue
    {
        {get : return defenseValue; }
    }


    public void RecibirAtaque(int damage) // Pide el valor de su método de ataque, para reducir su vida en ese entero
    {
        //Reducir health en función del daño reducido
    }
    public void Curar()
    {
        //aumentar health
    }
}