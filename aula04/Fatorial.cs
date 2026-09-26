using System;

int numero;
Console.WriteLine("Digite um número");
numero = Convert.ToInt32(Console.ReadLine());

Console.Write("Fatorial de "+numero+"! -> 1");
int fat = 1;
for(int i = 2; i<=numero; i++){
    fat = fat * i;
    Console.Write(" * "+i);  
}
Console.Write (" = "+fat);  