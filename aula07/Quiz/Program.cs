using Spectre.Console;

static void mostrarQuestao(string enunciado, string[] itens) {
    SelectionPrompt<string> selPrompt = new SelectionPrompt<string>();
    selPrompt.Title(enunciado);
    selPrompt.AddChoices(itens);
    string opcao = AnsiConsole.Prompt(selPrompt);
    Console.WriteLine("Você escolheu: "+opcao);
}

string enunciado = "Qual o doce mais gostoso da Arcor?";
string[] itens = { 
    "Tortuguita",
    "Tortita",
    "Panetone",
    "Paçoca",
};

Console.Clear();

mostrarQuestao(enunciado,itens);
mostrarQuestao(enunciado,itens);
mostrarQuestao(enunciado,itens);


