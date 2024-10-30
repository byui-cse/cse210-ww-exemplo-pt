using System;

class Program
{
    static void Main(string[] args)
    {
        ExibirMensagemBoasVindas();

        string nomeUsuario = PerguntarNomeUsuario();
        int numeroUsuario = PerguntarNumeroUsuario();

        int numeroAoQuadrado = NumeroAoQuadrado(numeroUsuario);

        ExibirResultado(nomeUsuario, numeroAoQuadrado);
    }

    static void ExibirMensagemBoasVindas()
    {
        Console.WriteLine("Bem-vindo ao programa!");
    }

    static string PerguntarNomeUsuario()
    {
        Console.Write("Por favor digite seu nome: ");
        string nome = Console.ReadLine();

        return nome;
    }

    static int PerguntarNumeroUsuario()
    {
        Console.Write("Por favor digite seu numero favorito: ");
        int numero = int.Parse(Console.ReadLine());

        return numero;
    }

    static int NumeroAoQuadrado(int numero)
    {
        int quadrado = numero * numero;
        return quadrado;
    }

    static void ExibirResultado(string nome, int quadrado)
    {
        Console.WriteLine($"{nome}, the square of your number is {quadrado}");
    }
}
