String linha;
bool conversaoOk;

Console.Clear();

Console.WriteLine("Digite seu nickname:");
String nickname = Console.ReadLine();
if (nickname == null || nickname == "") {
    Console.WriteLine("ERRO na entrada 1 (nickname): dado ausente (ou fim do arquivo).");
    Environment.Exit(1);
}

Console.WriteLine("Digite faixa etaria:");
linha = Console.ReadLine();
int faixaEtaria;
conversaoOk = int.TryParse(linha, out faixaEtaria);
if(!conversaoOk) {
    Console.WriteLine("ERRO na entrada 2 (faixa etaria): dado ausente/inválido (ou fim do arquivo).");
    Environment.Exit(1);
}
if(faixaEtaria < 1 || faixaEtaria > 6) {
    Console.WriteLine("ERRO na entrada 2 (faixa etaria): faixa inválida.");
    Environment.Exit(1);    
}
String nomeFaixa = "Até 12 anos";
if(faixaEtaria == 2) {
    nomeFaixa = "13 a 17 anos";
}
if(faixaEtaria == 3) {
    nomeFaixa = "18 a 24 anos";
}
if(faixaEtaria == 4) {
    nomeFaixa = "25 a 39 anos";
}


Console.WriteLine("===== ARCOR – DESAFIO DAS MARCAS: RESUMO DA PARTIDA =====");
Console.WriteLine("Jogador: "+nickname);
Console.WriteLine("Faixa etária: "+nomeFaixa);