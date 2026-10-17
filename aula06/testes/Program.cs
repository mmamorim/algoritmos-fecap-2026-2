using Spectre.Console;

Console.Clear();

//string[] produtos = { "Feijão", "Arroz", "Batata", "Tomate", "Cebola" };
//
//string prod = AnsiConsole.Prompt(
//    new SelectionPrompt<string>()
//        .Title("Escolha um produto:")
//        .AddChoices(produtos));
//
//Console.WriteLine("Produto: "+prod);
//
//int pos = Array.IndexOf(produtos,prod);
//Console.WriteLine("Posição: "+pos);

string[] produtos = { "Arroz", "Feijão", "Leite", "Café", "Sair" };
double[] precos = { 25.90, 8.50, 5.20, 18.00 };
//int[] sacola = { 2, 2, 2, 2 }; // Arroz, Leite, Leite, Café
List<int> sacola = new List<int>();

double total = 0;
string prod = AnsiConsole.Prompt(
    new SelectionPrompt<string>()
        .Title("Escolha um produto:")
        .AddChoices(produtos));

while(prod != "Sair") {
    int indice = Array.IndexOf(produtos,prod);
    Console.WriteLine($"{produtos[indice]} - R$ {precos[indice]:F2}");
    total += precos[indice];
    prod = AnsiConsole.Prompt(
    new SelectionPrompt<string>()
        .Title("Escolha um produto:")
        .AddChoices(produtos));
}

Console.WriteLine($"Total: R$ {total:F2}");