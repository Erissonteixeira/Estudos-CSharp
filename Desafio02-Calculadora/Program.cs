Console.WriteLine("\n===== CALCULADORA =====");

Console.Write("Digite o primeiro número: ");
int numero1 = int.Parse(Console.ReadLine());

Console.Write("Digite o segundo número: ");
int numero2 = int.Parse(Console.ReadLine());

Console.WriteLine("\n ===== Menu de operações ===== ");
Console.WriteLine("1 - Soma ");
Console.WriteLine("2 - Subtração ");
Console.WriteLine("3 - Multiplicação ");
Console.WriteLine("4 - Divisão ");

Console.Write("\nDigite Sua Opção: ");
int opcao = int.Parse(Console.ReadLine());

int resultado = 0;

if(opcao == 1)
{
    resultado = numero1 + numero2;
}
else if(opcao == 2)
{
    resultado = numero1 - numero2;
}
else if(opcao == 3)
{
    resultado = numero1 * numero2;
}
else if(opcao == 4)
{
    resultado = numero1 / numero2;
}
else
{
    Console.WriteLine("Opção invalida");
}

Console.WriteLine("Resultado: " + resultado);



