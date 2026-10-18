Console.WriteLine("Provide the number of rations: ");
int rations = int.Parse(Console.ReadLine()!);

Console.WriteLine("Provide the number of members: ");
int members = int.Parse(Console.ReadLine()!);

Console.WriteLine("Provide the number of days: ");
int day = int.Parse(Console.ReadLine()!);

int rationsPerMember = rations / members;
int rationsLeft = rations % members;
double dailyTeamRations = Math.Round((double)rations / day, 2);
double dailyRationsPerMember = Math.Round((double)rationsPerMember / day, 2);

Console.WriteLine($"Each member gets {rationsPerMember} rations per day.");
Console.WriteLine($"There are {rationsLeft} rations left.");
Console.WriteLine($"The team has {dailyTeamRations} rations per day.");
Console.WriteLine($"Each member has {dailyRationsPerMember} rations per day.");
