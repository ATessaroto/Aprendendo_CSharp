using System;
class programa
{
    static void Main(string[] args)
    {
        double salario = 7000.15;
        Console.WriteLine(salario);

        int salarioInteiro = (int)salario; //(int) Serve Para declarar que o programa apenas mostre os numeros inteiros
        Console.WriteLine(salarioInteiro);

        //O long é um tipo de variável de 64 bits
        long x = 2000000000000000000;
        Console.WriteLine(x);

        //O Short é para operações apenas com numeros Pequenos
        short y = 15000;
        Console.WriteLine(y);

        float altura = 1.62f;//F após o numero para declarar que o mesmo é um Float
        Console.WriteLine(altura);

        Console.Write("Tecle enter para fechar: ");
        Console.ReadLine();
    }
}
 