using System;
int numero;

Console.WriteLine("Qual tabuada?");
numero = Convert.ToInt32(Console.ReadLine());

int i = 0;
while(i<=10) {
    int valor = i * numero;
    Console.WriteLine (i+" x "+numero+" = "+valor);   
    i++;
}