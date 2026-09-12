
int horaIni, horaFim, minIni, minFim;
int qtdeMinInicio, qtdeMinFinal;

Console.WriteLine("Digite a hora de início da reunião: ");
horaIni = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite os minutos de início da reunião: ");
minIni = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite a hora de Término da reunião: ");
horaFim = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite os minutos de Término da reunião: ");
minFim = Convert.ToInt32(Console.ReadLine());

qtdeMinInicio = horaIni*60 + minIni;
qtdeMinFinal = horaFim*60 + minFim;
//Console.WriteLine("qtdeMinInicio "+qtdeMinInicio);
//Console.WriteLine("qtdeMinFinal "+qtdeMinFinal);
int totalMin = qtdeMinFinal - qtdeMinInicio;
int horas = totalMin / 60;
int minutos = totalMin % 60;

//Console.WriteLine("Tempo de duração "+horas+":"+minutos);
Console.WriteLine($"Tempo de duração {horas}:{minutos}");


