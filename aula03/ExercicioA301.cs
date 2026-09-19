using System;
					
double salario;
Console.WriteLine("Digite um salario");
salario = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Salario antigo "+salario);
/*
if(salario <= 2000) {
    salario = salario * 1.5;
}
if(salario > 2000 && salario < 5000) {
    salario = salario * 1.2;
}
if(salario >= 5000) {
    salario = salario * 1.1;
}
*/
if(salario <= 2000) {
    salario = salario * 1.5;
} else {
    if(salario < 5000) {
        salario = salario * 1.2;
    } else {
        salario = salario * 1.1;        
    }
}

Console.WriteLine("Seu novo salário é: "+salario);