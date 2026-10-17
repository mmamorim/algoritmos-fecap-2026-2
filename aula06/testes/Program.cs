using Spectre.Console;

Console.Clear();

string[] produtos = { "Feijão", "Arroz", "Batata", "Tomate", "Cebola" };

string prod = AnsiConsole.Prompt(
    new SelectionPrompt<string>()
        .Title("Escolha um produto:")
        .AddChoices(produtos));

Console.WriteLine("Produto: "+prod);

int pos = Array.IndexOf(produtos,prod);
Console.WriteLine("Posição: "+pos);
