# Spectre.Console — deixando o console mais interessante

O [Spectre.Console](https://spectreconsole.net/) é uma biblioteca que ajuda a criar programas de console mais bonitos e interativos: textos coloridos, tabelas, menus com setas, entradas validadas e mais.

> **Importante:** esta biblioteca é um **extra**. Nas aulas, o foco é a lógica (decisões, laços, etc.). Use o Spectre.Console como acabamento, depois que a lógica do seu programa estiver funcionando.

## Instalação

O Spectre.Console **não vem com o .NET**: ele é um pacote NuGet que precisa ser instalado em cada projeto. Na pasta do projeto (por exemplo, no terminal do VS Code), execute:

```bash
dotnet add package Spectre.Console
```

Depois, coloque no topo do arquivo:

```csharp
using Spectre.Console;
```

Sem o pacote instalado, ou sem esse `using`, o compilador não encontra as classes da biblioteca (como `Table` e `AnsiConsole`).

## `Console` x `AnsiConsole`

- `Console` é do .NET e serve para texto simples.
- `AnsiConsole` é do Spectre.Console e faz o mesmo papel, com recursos extras (cores, tabelas, menus).

Classes como `Table`, `Panel`, `Rule` e `FigletText` também são do Spectre.Console. Elas só **descrevem** o que será mostrado; quem **desenha** na tela é o `AnsiConsole.Write(...)`.

## Textos coloridos com `MarkupLine`

```csharp
AnsiConsole.MarkupLine("[bold green]Olá[/], [yellow]mundo[/]!");
```

Os colchetes são uma "linguagem de marcação" do Spectre.Console, parecida com HTML: você **abre** um estilo, escreve o texto e **fecha** com `[/]`.

| Trecho | O que faz |
|---|---|
| `[bold green]` | abre o estilo: negrito e verde |
| `Olá` | texto que recebe o estilo |
| `[/]` | fecha o último estilo aberto |
| `[yellow]mundo[/]` | "mundo" em amarelo |

Mais exemplos:

```csharp
AnsiConsole.MarkupLine("[red]Erro:[/] valor inválido");
AnsiConsole.MarkupLine("[bold underline blue]Título[/]");   // vários estilos juntos
```

Só o `AnsiConsole.MarkupLine` (ou `AnsiConsole.Markup`, que não pula linha) entende essa sintaxe. O `Console.WriteLine` comum mostraria os colchetes literalmente.

### Cuidado com os colchetes

Como `[` e `]` têm significado especial, para mostrar colchetes de verdade no texto, dobre-os:

```csharp
AnsiConsole.MarkupLine("Lista: [[1, 2, 3]]");   // Saída: Lista: [1, 2, 3]
```

Se o texto vier de uma variável (por exemplo, o que o usuário digitou), use `Markup.Escape(...)`:

```csharp
AnsiConsole.MarkupLine($"Você digitou: {Markup.Escape(texto)}");
```

## Entrada de dados

### Texto e número (já converte o tipo)

```csharp
string nome = AnsiConsole.Ask<string>("Qual é o seu [green]nome[/]?");
int idade = AnsiConsole.Ask<int>("Qual é a sua [green]idade[/]?");
```

Se o usuário digitar "abc" na idade, a biblioteca avisa e pergunta de novo.

### Entrada com validação

```csharp
int nota = AnsiConsole.Prompt(
    new TextPrompt<int>("Digite a nota (0 a 10):")
        .Validate(n => n >= 0 && n <= 10
            ? ValidationResult.Success()
            : ValidationResult.Error("[red]A nota deve estar entre 0 e 10[/]")));
```

### Confirmação (sim/não)

```csharp
bool continuar = AnsiConsole.Confirm("Deseja continuar?");
```

Retorna `true` ou `false`. Por padrão, aceita `y` ou `n` (em inglês).

## Menus

### Menu de seleção com setas

```csharp
string opcao = AnsiConsole.Prompt(
    new SelectionPrompt<string>()
        .Title("Escolha uma operação:")
        .AddChoices("Somar", "Subtrair", "Multiplicar", "Sair"));
```

O usuário navega com as setas ↑ ↓ e confirma com Enter. O valor escolhido fica na variável `opcao`, e você pode tratá-lo com um `switch`, como no exercício do menu de operações.

### Seleção múltipla

```csharp
List<string> frutas = AnsiConsole.Prompt(
    new MultiSelectionPrompt<string>()
        .Title("Quais frutas você gosta?")
        .NotRequired()
        .AddChoices("Maçã", "Banana", "Uva"));
```

A tecla Espaço marca ou desmarca uma opção, e o Enter confirma.

## Saída formatada

### Tabela

```csharp
var tabela = new Table();
tabela.AddColumn("Aluno");
tabela.AddColumn("Nota");
tabela.AddRow("Ana", "9.5");
tabela.AddRow("Bruno", "7.0");
AnsiConsole.Write(tabela);
```

Combina bem com laços: você pode chamar `AddRow` a cada volta de um `for` (por exemplo, para montar uma tabuada).

### Títulos, painéis e letras grandes

```csharp
AnsiConsole.Write(new Rule("[yellow]Resultado[/]"));
AnsiConsole.Write(new Panel("Aprovado!").Header("Situação"));
AnsiConsole.Write(new FigletText("FECAP").Color(Color.Green));
```

### Indicador de "carregando"

```csharp
AnsiConsole.Status().Start("Calculando...", ctx =>
{
    Thread.Sleep(2000);   // simula uma tarefa demorada
});
```

## Dicas e pontos de atenção

- Os menus com setas e os demais prompts interativos precisam de um **terminal de verdade**. No VS Code, rode o programa no terminal integrado (`dotnet run`), e não no Debug Console.
- Em plataformas online como o .NET Fiddle, esses recursos interativos podem não funcionar direito. Teste antes de contar com eles.
- Os exemplos acima usam a API que a biblioteca mantém há bastante tempo, mas pode haver pequenas diferenças entre versões. Em caso de dúvida, consulte a [documentação oficial](https://spectreconsole.net/).
