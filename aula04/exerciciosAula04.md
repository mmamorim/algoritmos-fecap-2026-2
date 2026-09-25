

# Exercícios — Desvios Condicionais e Laços de Repetição

Lista de exercícios misturando estruturas de decisão (`if`/`else`, `switch`) e estruturas de repetição (`for`, `while`, `do-while`), em ordem crescente de dificuldade. Cada exercício traz um exemplo de entrada e saída para ilustrar o que se espera do programa.

#### Exercício 1 — Tabuada
> Ler um número inteiro e exibir sua tabuada (de 1 a 10).

**Exemplo:**
```
Entrada: 7

Saída:
7 x 1 = 7
7 x 2 = 14
7 x 3 = 21
...
7 x 10 = 70
```

#### Exercício 2 — Soma dos pares
> Ler um número inteiro N e calcular a soma de todos os números pares entre 1 e N.

**Exemplo:**
```
Entrada: 10
Saída: A soma dos pares entre 1 e 10 é 30 (2+4+6+8+10)
```

#### Exercício 3 — Fatorial
> Ler um número inteiro N e calcular o seu fatorial (N!).

**Exemplo:**
```
Entrada: 5
Saída: 5! = 120 (5 x 4 x 3 x 2 x 1)
```

#### Exercício 4 — Número primo
> Ler um número inteiro e informar se ele é primo ou não.

**Exemplo:**
```
Entrada: 7        Entrada: 8
Saída: Primo       Saída: Não é primo
```

#### Exercício 5 — Contagem de positivos e negativos
> Ler uma sequência de números inteiros, um de cada vez, até que o usuário digite 0. Ao final, informar quantos números foram positivos e quantos foram negativos.

**Exemplo:**
```
Entrada: 5, -3, 2, -8, 0  (0 encerra a leitura)
Saída: Positivos: 2 | Negativos: 2
```

#### Exercício 6 — Média de N notas
> Perguntar ao usuário quantas notas ele quer informar (N). Em seguida, ler as N notas e calcular a média.

**Exemplo:**
```
Entrada: N = 3, notas = 7, 8, 9
Saída: A média é 8.0
```

#### Exercício 7 — Maior e menor valor
> Ler uma sequência de números inteiros, um de cada vez, até que o usuário digite -1. Ao final, informar o maior e o menor valor digitados.

**Exemplo:**
```
Entrada: 4, 9, -2, 7, -1  (-1 encerra a leitura)
Saída: Maior: 9 | Menor: -2
```

#### Exercício 8 — Sequência de Fibonacci
> Ler um número inteiro N e exibir os N primeiros termos da sequência de Fibonacci (0, 1, 1, 2, 3, 5, 8, ...).

**Exemplo:**
```
Entrada: 6
Saída: 0, 1, 1, 2, 3, 5
```

#### Exercício 9 — Menu de operações
> Crie um menu com as opções: 1) Somar dois números, 2) Subtrair dois números, 3) Multiplicar dois números, 4) Sair. O programa deve exibir o menu, executar a operação escolhida e voltar a exibir o menu novamente, repetindo esse processo até que o usuário escolha a opção Sair.

**Exemplo:**
```
--- MENU ---
1) Somar
2) Subtrair
3) Multiplicar
4) Sair
Escolha uma opção: 1
Digite dois números: 4 e 6
Resultado: 10

--- MENU ---
1) Somar
2) Subtrair
3) Multiplicar
4) Sair
Escolha uma opção: 4
Encerrando o programa...
```

#### Exercício 10 — Jogo de adivinhação
> O programa "pensa" em um número inteiro aleatório entre 1 e 100. O usuário tenta adivinhar o número, e a cada tentativa o programa informa se o número é maior, menor ou se o usuário acertou. O jogo continua até o usuário acertar, e ao final deve exibir quantas tentativas foram necessárias.

**Dica de desenvolvimento:** enquanto estiver programando e testando, é uma boa prática exibir na tela o número que o computador "pensou" (com um `Console.WriteLine`), para facilitar conferir se o jogo está funcionando direito. Quando terminar de testar, comente essa linha (colocando `//` na frente) para que o usuário não veja o número sorteado ao jogar.

**Gerando um número aleatório em C#:** use a classe `Random`, do `System`:
```csharp
Random sorteador = new Random();
int numeroPensado = sorteador.Next(1, 101);
// Console.WriteLine(numeroPensado); // descomente para testar, depois comente de novo
```
O método `Next(min, max)` sorteia um número inteiro entre `min` (inclusive) e `max` (exclusive) — por isso o segundo argumento é 101, para incluir o 100 como possibilidade.

**Exemplo:**
```
(o programa "pensou" no número 42)

Tente adivinhar: 50
O número é menor que 50.

Tente adivinhar: 25
O número é maior que 25.

Tente adivinhar: 42
Parabéns! Você acertou em 3 tentativas.
```