int heroHealth = 10;
int monsterHealth = 10;
int damage = 0;

Random dice = new Random();

//Continue the loop as long as both Hero and Monster
//health are more than zero
while (heroHealth > 0 && monsterHealth > 0)
{
    //Hero attacks
    damage = dice.Next(1, 10);
    monsterHealth -= damage;
    Console.WriteLine($"Hero attacks for: {damage}");
    Console.WriteLine($"Monster's health: {monsterHealth}");

    //Monster attacks
    damage = dice.Next(1, 10);
    heroHealth -= damage;
    Console.WriteLine($"Monster attacks for: {damage}");
    Console.WriteLine($"Hero's health: {heroHealth}");
}

