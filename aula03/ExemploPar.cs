
using System;
					
int valor;
Console.WriteLine("Digite um valor");
valor = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Vc digitou "+valor);

if(valor % 2 == 0) {
    Console.WriteLine("O número é par");
} else {
    Console.WriteLine("O número é impar");
}