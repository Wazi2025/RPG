int heroHealth = 10;
int monsterHealth = 10;
int damage = 0;

Random dice = new Random();

while ((heroHealth > 0) || (monsterHealth > 0))
//while (monsterHealth > 0)
{
    //Hero attacks
    damage = dice.Next(1, 10);
    monsterHealth -= damage;
    Console.WriteLine($"Hero attacks for: {damage}");
    Console.WriteLine($"Monster's health: {monsterHealth}");

    if (monsterHealth < 0)
        continue;
    //Monster attacks
    damage = dice.Next(1, 10);
    heroHealth -= damage;
    Console.WriteLine($"Monster attacks for: {damage}");
    Console.WriteLine($"Hero's health: {heroHealth}");
}

