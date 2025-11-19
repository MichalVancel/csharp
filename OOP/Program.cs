using OOP;
string PlayerName = Console.ReadLine();
Player player = new Player();
player.SetName(PlayerName);
Monster monster = new Monster();

player.DealDamage( monster);
monster.DealDamage( player);

Console.WriteLine();