
using Spectre.Console;

Console.WriteLine("Hello, World!");

AnsiConsole.MarkupLine("[bold green]Olá[/], [yellow]mundo[/]!");
AnsiConsole.MarkupLine("[red]Erro:[/] valor inválido");
AnsiConsole.MarkupLine("[bold underline blue]Título[/]");   // vários estilos juntos

//string nome = AnsiConsole.Ask<string>("Qual é o seu [green]nome[/]?");
//int idade = AnsiConsole.Ask<int>("Qual é a sua [green]idade[/]?");

//AnsiConsole.MarkupLine("[red]NOME:[/], [yellow]"+nome+"[/]!");
//AnsiConsole.MarkupLine("[red]IDADE:[/], [yellow]"+idade+"[/]!");

var selecao = new SelectionPrompt<string>();
selecao.Title("Escolha uma operação:");
selecao.AddChoices("Somar", "Subtrair", "Multiplicar", "Sair");

string opcao = AnsiConsole.Prompt(selecao);
Console.WriteLine("Você escolheu: "+opcao);

var tabela = new Table();
tabela.AddColumn("Aluno");
tabela.AddColumn("Nota");
tabela.AddColumn("Fruta");
tabela.AddRow("Ana", "9.5", "Pera");
tabela.AddRow("Bruno", "7.0", "Laranja");
tabela.AddRow("Ana", "9.5", "Pera");
AnsiConsole.Write(tabela);

AnsiConsole.Write(new Rule("[yellow]Resultado[/]"));
AnsiConsole.Write(new Panel("Aprovado!").Header("Situação"));
AnsiConsole.Write(new FigletText("FECAP").Color(Color.Green));

AnsiConsole.Status().Start("Calculando...", ctx => {
    Thread.Sleep(2000);   // simula uma tarefa demorada
    AnsiConsole.MarkupLine("[bold green]Olá[/], [yellow]mundo[/]!");
    Thread.Sleep(2000);   // simula uma tarefa demorada
    AnsiConsole.MarkupLine("[bold green]Olá[/], [yellow]mundo[/]!");
});