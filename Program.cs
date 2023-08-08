// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome! Ticket is $5. Please insert cash.");

int cash = Convert.ToInt32(Console.ReadLine());

if (cash < 5)
{
    Console.WriteLine("Not enough money dudes!");
}
else if (cash == 5)
{
    Console.WriteLine("Here's your ticket!");
}
else
{
    int change = cash - 5;
    Console.WriteLine("Here's your ticket, and $" + change + " change");
}



//Brackeys
Console.ReadKey();
