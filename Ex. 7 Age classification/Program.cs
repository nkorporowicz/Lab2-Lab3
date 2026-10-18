Console.WriteLine("Enter your age: ");
int age = int.Parse(Console.ReadLine()!);

if (age<0)
{
    Console.WriteLine("Age is incorrect");
} else if (age <= 12)
{
    Console.WriteLine("You are a child");
} else if (age <= 17)
{
    Console.WriteLine("You are a teenager");
} else if (age <= 64)
{
    Console.WriteLine("You are an adult");
} else
{
    Console.WriteLine("You are a senior");
}