using System;

int numero;
Console.WriteLine("Digite um número");
numero = Convert.ToInt32(Console.ReadLine());

int soma = 0;
for(int i = 0; i<=numero; i=i+2){
    soma = soma + i;
    Console.WriteLine (i);  
}
Console.WriteLine ("Soma é "+soma);