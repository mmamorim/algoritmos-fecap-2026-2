
double ni, pi, provaFinal, media;

Console.WriteLine("Digite sua nota NI:");
ni = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite sua nota PI:");
pi = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite sua nota Prova Final:");
provaFinal = Convert.ToDouble(Console.ReadLine());
media = ni*0.2 + pi*0.3 + provaFinal*0.5;
Console.WriteLine("Sua média é "+media);