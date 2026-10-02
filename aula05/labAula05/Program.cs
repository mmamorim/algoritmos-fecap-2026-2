
Console.Clear();

Console.WriteLine("Digite seu nickname");
String nickname = Console.ReadLine();

int faixaEtaria = Convert.ToInt32(Console.ReadLine());
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