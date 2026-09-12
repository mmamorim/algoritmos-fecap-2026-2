
Console.WriteLine("Digite sua peso: ");
double peso = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite sua altura: ");
double altura = Convert.ToDouble(Console.ReadLine());

double imc = peso / (altura*altura);

Console.WriteLine("Seu IMC é "+imc);
 