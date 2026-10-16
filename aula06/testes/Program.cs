using Spectre.Console;

Console.WriteLine("Hello, World!");

Console.Clear();

AnsiConsole.MarkupLine("[bold underline blue]Título[/]");

string[] opcoes = { "Somar", "Subtrair", "Multiplicar", "Sair" };

Console.WriteLine("--- MENU ---");

for (int i = 0; i < opcoes.Length; i++) {
    Console.WriteLine(i + 1 + "- " + opcoes[i]);
}