namespace Roguelike.Game;

public class Player
{
    public string Name { get; }
    public int Health { get; private set; }
    public int Attack { get; }

    public bool IsAlive => Health > 0;

    public Player(string name, int health, int attack)
    {
        Name = name;
        Health = health;
        Attack = attack;
    }

    public void TakeDamage(int damage)
    {
        if (damage <= 0)
        {
            return;
        }

        Health -= damage;

        if (Health < 0)
        {
            Health = 0;
        }
    }
}