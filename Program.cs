int heroHealth = 10;
int monsterHealth = 10;
int damage = 0;

Random dice = new Random();

while (heroHealth > 0 || monsterHealth > 0)
{
    damage = dice.Next(1, 10);
    monsterHealth -= damage;
}

Console.WriteLine($"Monster's health: {monsterHealth}");

Console.WriteLine($"Monster's health: {heroHealth}");