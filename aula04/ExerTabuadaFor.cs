using System;
int numero;

Console.WriteLine("Qual tabuada?");
numero = Convert.ToInt32(Console.ReadLine());

for(int i = 0; i<=10; i++){
    int valor = i * numero;
    Console.WriteLine (i+" x "+numero+" = "+valor);  
}