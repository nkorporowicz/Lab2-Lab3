int exp = 137;
int gold = 78;
int training = 1;

Console.WriteLine("===PLAYER STATS===");
Console.WriteLine($"Experience: {exp}");
Console.WriteLine($"Gold: {gold}");
Console.WriteLine($"Training Level: {training}");

exp += 25;
exp *= 2;
gold -= 8;
gold = gold + 15;
training++;

Console.WriteLine("\n\n===FINAL PLAYER STATS===");
Console.WriteLine($"Experience: {exp}");
Console.WriteLine($"Gold: {gold}");
Console.WriteLine($"Training Level: {training}");