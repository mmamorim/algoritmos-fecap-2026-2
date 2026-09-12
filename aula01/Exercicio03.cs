
int numero, c, d, u;

Console.WriteLine("Digite um numero com 3 digitos: ");
numero = Convert.ToInt32(Console.ReadLine());

c = numero / 100;
u = numero % 10;
d = (numero / 10) % 10;
Console.WriteLine("Unidade: "+u);
Console.WriteLine("Dezena: "+d);
Console.WriteLine("Centena: "+c);
