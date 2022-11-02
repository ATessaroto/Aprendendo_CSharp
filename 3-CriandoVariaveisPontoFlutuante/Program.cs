 using System;
class programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("projeto 3 - Variáveis Ponto Flutuante");

        double salario = 3000.10; ; // Double aceita números com pontos flutuantes e numeros Inteiros, basta sinalizar

        Console.WriteLine("" + salario);

        salario = 3000;

        Console.WriteLine("" + salario);

        double idade = 7.0 / 5; // colocar o ".0" apos o numero para sinalizar ao programa que se trata de um floating num

        Console.WriteLine(idade);

        Console.Write("Tecle enter para fechar: ");
        Console.ReadLine();

    }
}