// 1.

Console.Write("Add meg a csoki gyartasi sorszamat: ");
int number = int.Parse(Console.ReadLine());

int div = 0;

for (int i = 1; i < number+1; i++)
{
    if (number % i == 0)
    {
        div++;
    }
    else
    {
        continue;
    }
}

if (div == 2)
{
    Console.WriteLine("Gratulalok, nyertel!");
}
else
{
    Console.WriteLine("Sajnos nem nyert!");
}

// 2.

Console.Write("Az intervallum also vegpontja: ");
int bottom = int.Parse(Console.ReadLine());

Console.Write("Az intervallum felso vegpontja: ");
int top = int.Parse(Console.ReadLine());


int sum = 0;
for (int i = bottom; i <= top; i++)
{
    if (i % 2 == 0)
    {
        sum += i;
    }
}

Console.WriteLine($"A(z) [{bottom}; {top}] intervallumba eso paros szamok osszege: {sum}");