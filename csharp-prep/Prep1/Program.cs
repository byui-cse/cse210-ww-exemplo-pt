using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Qual o seu primeiro nome? ");
        string first = Console.ReadLine();

        Console.Write("Qual o seu sobrenome? ");
        string last = Console.ReadLine();

        Console.WriteLine($"Seu nome é {last}, {first} {last}.");
    }
}
