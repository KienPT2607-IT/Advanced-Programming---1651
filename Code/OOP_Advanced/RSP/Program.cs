using RSP;
using System;

Player p1, p2;

Console.Write("Your name: ");
string name = Console.ReadLine();

Console.Write("Do you want to play first (y/n): ");
if (Console.ReadLine() == "y")
{
    p1 = new Player(name);
    p2 = new Bot();
}
else
{
    p2 = new Player(name);
    p1 = new Bot();
}

bool playing = true;
while (playing)
{
    p1.GenerateNumber();
    int n = p2.GuessNumber();
    int bet = p2.Bet();
    bool win = n == p1.Number;

    if (win) System.Console.WriteLine(p2.Name + " win");
    else System.Console.WriteLine(p2.Name + " lose");

    p2.UpdateBalance(bet, win);
    p1.UpdateBalance(bet, win);

    System.Console.WriteLine($"{p1.Name} - balance: {p1.Balance}");
    System.Console.WriteLine($"{p2.Name} - balance: {p2.Balance}");
    
    playing = p1.Balance >= 0 && p2.Balance >= 0;
}