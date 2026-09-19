using System;

Console.WriteLine("Digite sua peso: ");
double peso = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite sua altura: ");
double altura = Convert.ToDouble(Console.ReadLine());

double imc = peso / (altura*altura);

Console.WriteLine("Seu IMC é "+imc);

if(imc < 18.5) {
    Console.WriteLine("MAGRO");
} else {
    if(imc < 25) {
        Console.WriteLine("NORMAL");        
    } else {
        if(imc < 30) {
            Console.WriteLine("SOBREPESO");                    
        } else {
            Console.WriteLine("OBESO");                    
        }
    }
}