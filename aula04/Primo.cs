using System;

int numero;
Console.WriteLine("Digite um número");
numero = Convert.ToInt32(Console.ReadLine());

bool ehPrimo = true;
for(int i=2; i<numero; i++){
    if(numero % i == 0) {
        ehPrimo = false;        
    }
}
if(ehPrimo) {
    Console.WriteLine("EH PRIMO");
} else {
    Console.WriteLine("NAO EH PRIMO");    
}