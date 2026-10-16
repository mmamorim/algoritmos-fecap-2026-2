using Spectre.Console;

Console.WriteLine("Hello, World!");

Console.Clear();

AnsiConsole.MarkupLine("[bold underline blue]Título[/]");

string[] opcoes = { "Somar", "Subtrair", "Multiplicar", "Dividir", "Sair" };

Console.WriteLine("--- MENU ---");

//for (int i = 0; i < opcoes.Length; i++) {
//    Console.WriteLine(i + 1 + "- " + opcoes[i]);
//}

//int i = 0;
//foreach(string item in opcoes) {
//    i++;
//    Console.WriteLine(i + " - " + item);
//}

//var tabela = new Table();
//tabela.AddColumn("No.");
//tabela.AddColumn("Opção");
//for(int i=0; i < opcoes.Length; i++) {
//    tabela.AddRow(""+(i+1),opcoes[i]);    
//}
//AnsiConsole.Write(tabela);

string opcao = AnsiConsole.Prompt(
    new SelectionPrompt<string>()
        .Title("Escolha uma operação:")
        .AddChoices(opcoes));