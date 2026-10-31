using Spectre.Console;

static bool mostrarQuestao(string enunciado, string[] itens, string dica)
{
    SelectionPrompt<string> selPrompt = new SelectionPrompt<string>();
    selPrompt.Title(enunciado);
    selPrompt.AddChoices(itens);
    selPrompt.AddChoice("MOSTRAR DICA");
    selPrompt.AddChoice("TERMINAR");
    string opcao = AnsiConsole.Prompt(selPrompt);

    if (opcao == "MOSTRAR DICA")
    {
        AnsiConsole.Status().Start(dica, ctx => {
            Thread.Sleep(2000);   // simula uma tarefa demorada
        });
        return mostrarQuestao(enunciado,itens,dica);
    }
    //Console.WriteLine("Você escolheu: "+opcao);
    if (opcao == itens[0])
    {
        //Console.WriteLine("Você Acertou");
        return true;
    }
    else
    {
        //Console.WriteLine("Você Errou");            
        return false;
    }
}

string[] enunciados = {
     "Qual o doce mais gostoso da Arcor?",
     "Qual a cor do logo da Arcor?",
     "Sei lá o que vou perguntar....",
     "Qual o mais vendido?"
};

string[] niveis = { "F", "D", "M", "F" };

string[] dicas = {
    "Alguma dica para essa questão",
    "outra dica",
    "Mais uma dica",
    "Outra outra dica"
};

string[][] itens = {
    ["Tortuguita", "Tortita", "Panetone", "Paçoca"],
    ["Amarelo", "verde", "Azul", "Roxo" ],
    ["algo", "Outro", "Não sei", "mais um"],
    ["Panetone", "Tortuguita", "Tortita", "Paçoca"]
};

Console.Clear();

int acertos = 0;

for (int i = 0; i < 4; i++)
{
    bool acertou = mostrarQuestao(enunciados[i], itens[i], dicas[i]);
    if (acertou)
    {
        acertos++;
    }
}

Console.WriteLine("Acertos: " + acertos);


