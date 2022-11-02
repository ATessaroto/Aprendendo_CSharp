using System;
class programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("projeto 2 - Criando Variáveis");

        int idade;

        idade = 27;

        Console.WriteLine(" A Minha Idade é " + idade);

        idade = 27 - 5;

        Console.WriteLine(" A Minha Idade Subtraindo 5 é " + idade);

        idade = 5 * 2 - 6;

        Console.WriteLine(" A Idade do meu filho Subtraindo 6 é " + idade);

        idade = (5 - 2) * 3; // Igual os Calculos Matematicos: Regras de prioridade

        Console.WriteLine(" A Idade da minha filha Multiplicando por 3 é " + idade);

        Console.Write("Tecle enter para fechar: ");
        Console.ReadLine();
    }
}
