![alt](../assets/banner.png)

# Aula 01 - 04/09/2026

## Por que estudar Algoritmos e Lógica de Programação?

Esta disciplina é a base de tudo que vem depois no curso: toda linguagem e tecnologia que você vai usar mais adiante depende de um raciocínio lógico bem construído. O objetivo aqui não é decorar sintaxe de linguagem nenhuma, e sim desenvolver a capacidade de resolver problemas passo a passo, de forma estruturada.

Vale reter uma ideia central: sem lógica sólida, nenhuma linguagem de programação "salva" o profissional — é a habilidade de raciocinar de forma estruturada que fica com você ao longo da carreira. Esta disciplina é o primeiro passo de uma trilha, a base sobre a qual as próximas disciplinas de programação do curso serão construídas.

## O que vamos aprender ao longo do semestre

O conteúdo do semestre está organizado em quatro grandes blocos:

- **Fundamentos** — lógica, algoritmos, variáveis, tipos de dados e expressões aritméticas, relacionais e lógicas.
- **Estruturas de Controle** — estrutura sequencial, decisão (simples, composta, encadeada, múltipla escolha) e repetição (enquanto, faça/enquanto, para).
- **Dados Estruturados** — vetores, matrizes, registros e persistência de dados em arquivos.
- **Modularização** — funções e procedimentos, passagem de parâmetros (por valor e por referência) e recursividade.

## Como vamos trabalhar

**Metodologia:** as aulas serão expositivas, sempre com aplicação prática de exercícios e exemplos contextualizados. A disciplina também se integra ao Projeto Interdisciplinar (PI) do semestre, que tem caráter extensionista. A avaliação combina três frentes: Prova Intermediária + Atividades, o Projeto Interdisciplinar e a Prova Final.

**Ferramentas:** a linguagem adotada será C#, sobre a plataforma .NET, com o Visual Studio Code como editor de código. Os códigos usados em aula ficarão disponíveis em um repositório no GitHub, cujo link será compartilhado no início do curso.

---

## O que é um algoritmo?

Pense na atividade de instruir alguém a dobrar um papel apenas com palavras: a ambiguidade que costuma aparecer nesse tipo de exercício é exatamente o problema que um algoritmo resolve.

**Definição:** algoritmo é uma sequência finita de passos, bem definidos e ordenados, que leva à solução de um problema ou à realização de uma tarefa.

Para funcionar de verdade, um algoritmo precisa atender a quatro características:

1. **Finito** — tem começo, meio e fim; não roda para sempre.
2. **Preciso** — cada passo é claro, sem margem para interpretação dupla.
3. **Ordenado** — a sequência dos passos importa.
4. **Executável** — cada passo pode de fato ser realizado.

## Lógica e processamento de dados

**Lógica** é o raciocínio estruturado que usamos para chegar a uma conclusão ou resolver um problema — em outras palavras, é organizar o pensamento antes de organizar o código. Em programação, é a lógica que garante que o algoritmo realmente faz o que deveria fazer.

**Processamento de dados** segue sempre o mesmo ciclo básico, com três etapas:

- **Entrada** — os dados que o programa recebe.
- **Processamento** — o que é feito com esses dados.
- **Saída** — o resultado entregue ao usuário.

## Algoritmo × Programa × Linguagem de programação

Esses três termos são frequentemente confundidos, mas representam coisas diferentes:

- **Algoritmo** é a ideia — a sequência de passos que resolve o problema, independente de qualquer linguagem.
- **Programa** é a implementação dessa ideia em código, escrita em uma linguagem específica para ser executada pelo computador.
- **Linguagem de programação** é a ferramenta e a notação usadas para escrever o programa (C#, Python, Java, etc.).

Uma boa analogia: o algoritmo é a receita em si (os passos a seguir). O programa é a receita escrita à mão. E a linguagem de programação é o idioma em que essa receita foi escrita.

## Exemplos de algoritmos do dia a dia

Algoritmos não são exclusividade da computação — estão em várias situações cotidianas:

- **Receita culinária** — uma sequência de passos ordenados (ingredientes, modo de preparo) que leva a um prato pronto.
- **Manual de montagem** — passos numerados para montar um móvel, sempre na mesma ordem, sem pular etapas.
- **Rota do GPS** — uma sequência de instruções de navegação que leva do ponto A ao ponto B.
- **Troca de pneu** — passos precisos e ordenados, em que errar a ordem pode até ser perigoso.

---

## Como construir um algoritmo narrativo

Um algoritmo narrativo é escrever os passos em português claro (ou pseudocódigo), antes de qualquer linguagem de programação — é o rascunho da solução. Algumas boas práticas ajudam a escrever um bom algoritmo narrativo:

- Um passo por linha, numerado.
- Comece cada passo com um verbo de ação (leia, calcule, exiba, verifique...).
- Siga a ordem exata em que as coisas devem acontecer.
- Evite ambiguidade — se dá para interpretar de duas formas, reescreva.
- Pense em entrada, processamento e saída, na ordem em que aparecem.

### Exemplo prático

**Problema:** calcular a média de duas notas e informar se o aluno foi aprovado (média ≥ 6).

1. Leia a primeira nota do aluno.
2. Leia a segunda nota do aluno.
3. Calcule a média somando as duas notas e dividindo por 2.
4. Verifique se a média é maior ou igual a 6.
5. Se for, exiba a mensagem "Aprovado".
6. Se não for, exiba a mensagem "Reprovado".

## Fluxogramas: outra forma de representar algoritmos

Além do algoritmo narrativo, é possível representar o mesmo algoritmo visualmente, usando símbolos padronizados conectados por setas que indicam a ordem de execução. Os principais símbolos são:

- **Terminal (início/fim)** — indica onde o algoritmo começa ou termina.
- **Entrada/Saída** — representa a leitura de um dado ou a exibição de um resultado.
- **Processamento** — representa uma ação ou cálculo, como atribuir um valor a uma variável.
- **Decisão** — representa uma pergunta com duas saídas possíveis, geralmente Sim e Não.

As setas sempre indicam a ordem em que os passos devem ser seguidos.

### O mesmo exemplo, em fluxograma

Retomando o problema de calcular a média de duas notas (aprovado se média ≥ 6): o fluxo começa em **Início**, passa por **Ler a primeira nota** e **Ler a segunda nota**, segue para **Calcular a média**, chega à decisão **Média ≥ 6?** — que se ramifica em **Sim** (exibe "Aprovado") ou **Não** (exibe "Reprovado") — e termina em **Fim**.

---

## Constantes e variáveis

- **Variável** — um espaço de memória, identificado por um nome, que guarda um valor que pode mudar durante a execução do programa. Exemplo: a idade de um usuário, lida e guardada em memória.
- **Constante** — um valor fixo, definido uma vez, que não muda durante toda a execução do programa. Exemplo: o valor de PI, ou a alíquota de um imposto fixo.

## Tipos de dados

Os tipos de dados básicos que usaremos em C# são:

| Tipo | Representa | Exemplo |
|---|---|---|
| `int` | Números inteiros | `idade = 20` |
| `double` | Números com casas decimais | `altura = 1.75` |
| `string` | Texto / cadeia de caracteres | `nome = "Ana"` |
| `bool` | Verdadeiro ou falso | `aprovado = true` |
| `char` | Um único caractere | `sexo = 'F'` |

## Identificadores e boas práticas de nomenclatura

**Regras obrigatórias** para nomear identificadores em C#:

- Deve começar com letra ou underscore ( `_` ).
- Sem espaços e sem acentos.
- C# diferencia maiúsculas de minúsculas (`idade` ≠ `Idade`).
- Não pode ser uma palavra reservada da linguagem (como `class` ou `int`).

**Boas práticas recomendadas:**

- Use nomes descritivos: `idadeUsuario` em vez de `x`.
- Use camelCase para variáveis: `notaFinal`, `valorTotal`.
- Nomes de constantes em maiúsculas: `PI`, `TAXA_JUROS`.

---

## Primeiro programa em C#

Todo projeto em C# roda dentro de um programa. Na versão atual do .NET, o programa mais simples possível é apenas isto:

```csharp
Console.WriteLine("Olá, mundo!");
```

- `Console` é a classe que representa a tela e o teclado.
- `WriteLine` escreve um texto na tela e pula para a linha seguinte.
- Todo comando em C# termina com ponto e vírgula ( `;` ).

## Entrada de dados

Para ler o que o usuário digita, usamos `Console.ReadLine()`. Ele sempre devolve um texto (`string`) — mesmo que a pessoa digite um número. Por isso, quando o dado deve ser um número, é preciso converter o texto lido com `Convert.ToInt32`, `Convert.ToDouble`, etc.:

```csharp
string nome = Console.ReadLine();
int idade = Convert.ToInt32(Console.ReadLine());
double altura = Convert.ToDouble(Console.ReadLine());
```

### Exemplo prático: nome e idade

```csharp
Console.Write("Qual é o seu nome? ");
string nome = Console.ReadLine();
Console.Write("Qual é a sua idade? ");
int idade = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Olá, {nome}! Você tem {idade} anos.");
```

Repare no `$` antes das aspas: ele permite inserir variáveis diretamente dentro do texto, entre chaves `{ }`.

---

## Operadores aritméticos em C#

| Operador | Operação | Exemplo |
|---|---|---|
| `+` | Soma | `5 + 3 = 8` |
| `-` | Subtração | `5 - 3 = 2` |
| `*` | Multiplicação | `5 * 3 = 15` |
| `/` | Divisão | `6 / 3 = 2` |
| `%` | Resto da divisão | `5 % 3 = 2` |

### Cuidado com a divisão entre inteiros

Quando os dois operandos são `int`, o C# faz uma divisão inteira: o resultado é truncado, a parte decimal é descartada (não é arredondado).

```csharp
int a = 7, b = 2;
int resultadoInt = a / b;
// resultadoInt vale 3 (a parte .5 foi descartada)

double resultadoDouble = (double)a / b;
// resultadoDouble vale 3.5
```

O `(double)` antes de `a` é um *cast*: converte o valor de `a` para `double` antes da divisão, forçando o resultado a manter as casas decimais.

### Operador resto da divisão (%)

O operador `%` (chamado de módulo, ou "mod") devolve o que sobra de uma divisão inteira — o resto, não o resultado da divisão. Alguns exemplos: `10 % 3 = 1`, `8 % 2 = 0`, `7 % 4 = 3`, `15 % 5 = 0`.

Na prática, o `%` serve, entre outras coisas, para:

- Descobrir se um número é par ou ímpar: `n % 2 == 0` significa que é par.
- Pegar o último dígito de um número: `n % 10`.
- Separar unidades de medida, como transformar segundos totais em minutos e segundos restantes.

---

## Concatenação de strings com `+`

Para juntar textos e variáveis em uma única string, podemos usar o operador `+`. O C# converte números automaticamente para texto nessa operação:

```csharp
string nome = "Ana";
int idade = 25;
string mensagem = "Olá, " + nome + "! Você tem " + idade + " anos.";
```

Essa abordagem funciona bem para poucas variáveis, mas com uma frase longa fica difícil de ler — é aí que entra a interpolação com `$`.

## Interpolação de strings com `$`

Colocando um `$` antes das aspas, podemos inserir variáveis diretamente dentro do texto, entre chaves `{ }`. É mais legível do que somar vários pedaços com `+`.

```csharp
// Com + (concatenação)
"Olá, " + nome + "! Você tem " + idade + " anos.";

// Com $ (interpolação)
$"Olá, {nome}! Você tem {idade} anos.";
```

As duas formas produzem exatamente o mesmo resultado — a escolha entre elas é uma questão de legibilidade.

---

## Exercícios propostos

**Exercício 1 — Média FECAP**
Criar um programa em C# que calcule a média FECAP de um aluno. O programa deve solicitar ao usuário as notas de NI, PI e Prova Final, calcular a média ponderada com a fórmula da disciplina e exibir o resultado na tela.
Fórmula: `Média = NI * 0.20 + PI * 0.30 + ProvaFinal * 0.50`

**Exercício 2 — IMC (Índice de Massa Corporal)**
Criar um programa em C# que calcule o IMC de uma pessoa. O programa deve solicitar o peso (em quilogramas) e a altura (em metros), calcular o IMC e exibir o resultado.
Fórmula: `IMC = peso / (altura * altura)`

**Exercício 3 — Centena, dezena e unidade**
Ler um número inteiro de 3 dígitos e apresentar separadamente a centena, a dezena e a unidade desse número. Por exemplo, para 742: CENTENA = 7, DEZENA = 4, UNIDADE = 2.
Dica: combine os operadores `/` (divisão inteira) e `%` (resto) para isolar cada dígito.

**Exercício 4 — Duração de uma reunião**
Ler o horário de início e término de uma reunião e apresentar o tempo de duração, calculando a diferença em horas e minutos.
Dica: transforme os dois horários em minutos totais, subtraia, e use `/` e `%` para voltar a horas e minutos.

**Exercício 5 — Convertendo segundos em horas, minutos e segundos**
Ler uma quantidade total de segundos e apresentar quantas horas, minutos e segundos ela representa. Por exemplo, 3661 segundos correspondem a 1 hora, 1 minuto e 1 segundo.
Dica: a mesma ideia dos exercícios anteriores, aplicando `/` e `%` duas vezes seguidas.

---

## Recapitulando

Nesta primeira aula, vimos:

- O que é um algoritmo e como representá-lo: de forma narrativa e por fluxograma.
- A diferença entre algoritmo, programa e linguagem de programação.
- Constantes, variáveis, tipos de dados e boas práticas de nomenclatura.
- Primeiro contato com C#: saída (`WriteLine`) e entrada (`ReadLine`) de dados.
- Operadores aritméticos, com atenção especial ao resto da divisão (`%`).
- Concatenação (`+`) e interpolação (`$`) de strings.
- Prática com os exercícios de média, IMC, dígitos e duração de reunião.

**Próxima aula:** Estrutura Sequencial.