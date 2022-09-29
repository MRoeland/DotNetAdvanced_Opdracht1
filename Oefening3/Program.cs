// See https://aka.ms/new-console-template for more information

int totaal = 0;

for (int i = 1; i < 101; i++)
{
    if ((i * 7) > 546)
    {
        Console.WriteLine("Totaal " + (totaal + i) + " is te groot want i * 7 = " + i * 7);
        break;
    }
    else
    {
        totaal = totaal + i;
        Console.WriteLine("Totaal = " + totaal + ", i * 7 = " + i * 7);
    }
}