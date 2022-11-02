using System;
class programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 5 - Caracteres e Textos");

        char letra = 'a';           // Char usa a Tabela ASCII - Podendo Usar Números para representar palavras
        Console.WriteLine(letra);

        letra = (char)65; //Exemplo 65 = A 
        Console.WriteLine(letra);

        letra = (char)(65 + 1);
        Console.WriteLine(letra);

        letra = (char)(86 + 1);
        Console.WriteLine(letra);

        string primeiraFrase = "Alura - Cursos de tecnologia "; //String Guarda caracteres, mas também tem outras funções
        Console.WriteLine(primeiraFrase + 2022);

        string vazia = "";
        Console.WriteLine(vazia);

        letra = ' ';

        string cursos = @"Cursos disponíveis:   
        - C# 
        - VBA 
        - Java"; // O @ Permite a livre modificação de linhas e texto
        Console.WriteLine(cursos);


        Console.Write("Tecle enter para fechar: ");
        Console.ReadLine();
    }
}