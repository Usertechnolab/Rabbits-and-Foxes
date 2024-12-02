int rabbits = 100;
double rabbitBirthRate = 0.2;
double foxKillRate = 0.005;
int foxes = 10;
double foxBirthRate = 0.001;
double foxDeathRate = 0.2;
double rabbitsPrev = rabbits;
double foxesPrev = foxes;
double rabbitsNext = 0.0;
double foxesNext = 0.0;

for (int year =0; year<200; year++)
{
    if (rabbitsPrev > 0)
    {
        rabbitsNext = rabbitsPrev + (int)Math.Round(rabbitsPrev * rabbitBirthRate) - (int)Math.Round(rabbitsPrev * foxesPrev * foxKillRate);
        foxesNext = foxesPrev + (int)Math.Round(foxesPrev * rabbitsPrev * foxBirthRate) - (int)Math.Round(foxesPrev * foxDeathRate);
        Console.WriteLine("Year: " + year + " Rabbits: " + rabbitsNext + " Foxes: " + foxesNext);
        rabbitsPrev = rabbitsNext;
        foxesPrev = foxesNext;
        rabbitsPrev = Math.Max(0, rabbitsPrev);
        foxesPrev = Math.Max(0, foxesPrev);
    }
    else
    {
        foxesNext = 0;
    }
}