using Roguelike.Game;

Player player = new Player("Luiz", 100, 25);

int[] damages = { 30, 50, 40 };

foreach (int damage in damages)
{
    player.TakeDamage(damage);

    Console.WriteLine(
        $"{player.Name} recebeu {damage} de dano. Vida: {player.Health}"
    );

    if (!player.IsAlive)
    {
        Console.WriteLine($"{player.Name} foi derrotado.");
        break;
    }
}