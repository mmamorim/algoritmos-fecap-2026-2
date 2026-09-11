![alt](../assets/banner.png)

# Aula 02 - 11/09/2026

# Algoritmos e Lógica de Programação — Notas da Aula 02

## Recapitulando: operadores aritméticos

Antes de avançar, vale relembrar rapidamente o que vimos na aula anterior:

- `+`, `-`, `*`, `/` — as quatro operações básicas (soma, subtração, multiplicação e divisão).
- `%` — o resto da divisão, muito usado para descobrir se um número é par/ímpar, extrair dígitos e converter unidades.
- **Cuidado:** a divisão entre dois `int` trunca o resultado — a parte decimal é descartada.

Hoje o foco muda: vamos aprender operadores que respondem verdadeiro ou falso, e as estruturas que decidem o que o programa faz com essa resposta.

---

## Operadores relacionais

Operadores relacionais comparam dois valores. O resultado de uma comparação é sempre um `bool`: `true` (verdadeiro) ou `false` (falso).

| Operador | Significado | Exemplo | Resultado |
|---|---|---|---|
| `>` | Maior que | `5 > 3` | `true` |
| `<` | Menor que | `3 < 5` | `true` |
| `>=` | Maior ou igual | `5 >= 5` | `true` |
| `<=` | Menor ou igual | `4 <= 5` | `true` |
| `==` | Igual a | `5 == 5` | `true` |
| `!=` | Diferente de | `5 != 3` | `true` |

**Atenção:** `==` compara valores; `=` sozinho é usado para atribuir um valor a uma variável. Confundir os dois é um erro comum e uma boa fonte de bugs.

## Operadores lógicos

Operadores lógicos combinam expressões que já resultam em `bool`, formando condições mais complexas:

- `&&` — **E** (AND): as duas expressões precisam ser verdadeiras.
- `||` — **OU** (OR): basta uma das expressões ser verdadeira.
- `!` — **NÃO** (NOT): inverte o valor — `true` vira `false` e vice-versa.

### Tabela-verdade

| A | B | A `&&` B | A `\|\|` B |
|---|---|---|---|
| V | V | V | V |
| V | F | F | V |
| F | V | F | V |
| F | F | F | F |

O `!` inverte qualquer valor: `!V = F` e `!F = V`.

## Diferença entre E (`&&`) e OU (`||`)

Pensar em situações do dia a dia ajuda a fixar a diferença:

- **E (`&&`)** — as duas condições precisam ser verdadeiras. Exemplo: "Para dirigir, eu preciso ter mais de 18 anos **E** ter carteira de motorista." Se faltar qualquer uma das duas, não posso dirigir. Em código: `idade >= 18 && temCarteira`.
- **OU (`||`)** — basta uma condição ser verdadeira. Exemplo: "Posso pagar em dinheiro **OU** no cartão." Qualquer uma das duas formas já resolve o pagamento. Em código: `pagaDinheiro || pagaCartao`.

---

## Pratique: expressões lógicas

A seguir, três rodadas de expressões para praticar a avaliação de operadores relacionais e lógicos combinados.

### Rodada 1

1. `(5 > 3) && (3 >= 7)`
2. `(10 % 2 == 0) || (7 < 3)`
3. `!(4 > 10)`

**Respostas:**

1. `(5 > 3) && (3 >= 7)` → `true && false` → **falso**
2. `(10 % 2 == 0) || (7 < 3)` → `true || false` → **verdadeiro**
3. `!(4 > 10)` → `!(false)` → **verdadeiro**

### Rodada 2

1. `(5 > 3) && ((3 >= 7) || (5 + 3 >= 8))`
2. `(2 == 2) && (4 != 4)`
3. `(8 % 3 == 2) || (1 > 0 && 0 > 1)`

**Respostas:**

1. `(5 > 3) && ((3 >= 7) || (5 + 3 >= 8))` → `true && (false || true)` → **verdadeiro**
2. `(2 == 2) && (4 != 4)` → `true && false` → **falso**
3. `(8 % 3 == 2) || (1 > 0 && 0 > 1)` → `true || (true && false)` → **verdadeiro**

### Rodada 3 — com variáveis

```csharp
int x = 4, y = 10;
bool ehPar = true;
bool ehGrande = false;
```

1. `ehPar && (x + y) % 2 == 0`
2. `(x > y) || (!ehGrande && x < 10)`
3. `(y % x != 2) && (ehPar || ehGrande)`

**Respostas:**

1. `ehPar && (x + y) % 2 == 0` → `true && (14 % 2 == 0)` → `true && true` → **verdadeiro**
2. `(x > y) || (!ehGrande && x < 10)` → `false || (true && true)` → **verdadeiro**
3. `(y % x != 2) && (ehPar || ehGrande)` → `(10 % 4 != 2)` → `false` → **falso**

---

## Estrutura de decisão: `if` / `else`

O `if` executa um bloco de código somente quando uma condição é verdadeira. Se a condição for falsa, esse bloco é simplesmente pulado.

```csharp
if (idade >= 18) {
    Console.WriteLine("Maior de idade");
}
```

Um ponto importante: **o `if` nem sempre precisa de `else`**. O `else` só entra em cena quando existe uma ação alternativa para quando a condição é falsa. Se não há nada a fazer nesse caso, o `if` sozinho já resolve.

### Sintaxe do `if`/`else`: os principais casos

Existem seis combinações comuns de sintaxe, dependendo de haver ou não `else` e de o corpo ter uma linha só ou um bloco entre chaves:

**Caso 1 — comando único, sem chaves:**
```csharp
if (condição)
   comando1();
```

**Caso 2 — bloco de comandos, sem `else`:**
```csharp
if (condição) {
   comando1();
   comando2();
}
```

**Caso 3 — comando único, com `else`:**
```csharp
if (condição)
  comando1();
else
  comando2();
```

**Caso 4 — bloco no `if`, `else` de 1 linha:**
```csharp
if (condição) {
  comando1();
  comando2();
} else
  comando3();
```

**Caso 5 — `if` de 1 linha, bloco no `else`:**
```csharp
if (condição)
  comando1();
else {
  comando2();
  comando3();
}
```

**Caso 6 — bloco no `if` e no `else`:**
```csharp
if (condição) {
  comando1();
  comando2();
} else {
  comando3();
  comando4();
}
```

A regra por trás de tudo isso: sem chaves `{ }`, apenas o próximo comando pertence ao `if` (ou ao `else`). Com chaves, todo o bloco pertence a ele — é isso que define onde a estrutura começa e termina.

### Exercício guiado: par ou ímpar

Vamos programar juntos: leia um número inteiro e informe se ele é par ou ímpar.

1. Ler um número inteiro.
2. Verificar se o resto da divisão desse número por 2 é igual a 0.
3. Exibir "Par" ou "Ímpar", conforme o resultado.

Dica: use o operador `%` que já vimos, dentro de um `if`/`else`.

---

## Decisão encadeada: `else if`

Quando existem mais de duas possibilidades, encadeamos vários `else if`, um depois do outro:

```csharp
if (nota >= 9)
    conceito = "A";
else if (nota >= 7)
    conceito = "B";
else if (nota >= 5)
    conceito = "C";
else
    conceito = "D";
```

As condições são testadas em ordem, de cima para baixo; assim que uma é verdadeira, as demais nem são checadas.

## Decisão aninhada: `if` dentro de `if`

Às vezes só faz sentido verificar uma segunda condição depois que a primeira já foi verdadeira. Nesses casos, colocamos um `if` dentro de outro `if`:

```csharp
if (usuarioValido) {
    if (senhaValida) {
        Console.WriteLine("Acesso permitido");
    } else {
        Console.WriteLine("Senha incorreta");
    }
} else {
    Console.WriteLine("Usuário não encontrado");
}
```

Repare que só chegamos a checar a senha se o usuário já for válido — é exatamente esse o papel do aninhamento: evitar verificações que não fazem sentido antes que a condição anterior seja atendida.

## Estrutura de múltipla escolha: `switch`

Quando comparamos uma única variável a vários valores possíveis, o `switch` deixa o código mais organizado do que uma longa cadeia de `else if`:

```csharp
switch (diaSemana)
{
    case 1: Console.WriteLine("Domingo"); break;
    case 2: Console.WriteLine("Segunda"); break;
    case 3: Console.WriteLine("Terça"); break;
    // ...
    default: Console.WriteLine("Inválido"); break;
}
```

O `break` encerra o `case`; o `default` cobre os valores que não bateram com nenhum `case`. Para intervalos ou condições compostas, o `else if` continua sendo a melhor opção — o `switch` funciona bem quando a comparação é sempre de igualdade com uma mesma variável.

---

## Exercícios propostos

**Exercício 1 — Reajuste salarial**
Dado o valor atual do salário de um funcionário, informar o valor do salário reajustado. O programa deve ler o salário atual, aplicar o percentual de reajuste conforme a faixa em que o salário se encaixa e exibir o novo salário.
Regras: até R$ 2.000,00 → +50%; de R$ 2.000,01 a R$ 4.999,99 → +20%; demais (≥ R$ 5.000,00) → +10%.

**Exercício 2 — IMC com classificação**
O IMC de uma pessoa é dado pelo peso (kg) dividido pelo quadrado da altura (m). Dados peso e altura, informar a situação da pessoa: ler o peso em quilogramas, ler a altura em metros, calcular `IMC = peso / (altura * altura)` e classificar o resultado.
Regras: `imc ≤ 18.5` → magro; `18.5 < imc ≤ 25.0` → normal; `25.0 < imc ≤ 30.0` → sobrepeso; `imc > 30.0` → obeso.

**Exercício 3 — Ano bissexto**
Criar um programa que solicite um ano e verifique se ele é bissexto: ler o ano, verificar a condição de ano bissexto e exibir o resultado.
Condição: `(ano % 4 == 0 && ano % 100 != 0) || (ano % 400 == 0)`.

**Exercício 4 — Maior de 3 números**
Ler 3 números inteiros e apresentar o maior deles: ler os três números, comparar os valores entre si e exibir o maior.
Dica: pense em usar `if`/`else if` encadeados, ou `if` aninhados, comparando dois números de cada vez.

**Exercício 5 — Ordenar 3 números**
Ler 3 números inteiros e apresentá-los em ordem crescente: ler os três números, comparar os valores para descobrir a ordem entre eles e exibi-los ordenados.
Dica: são várias comparações possíveis — vale desenhar no papel todos os casos de ordem antes de programar.

**Exercício 6 — Validação de senha**
Criar um programa que solicite uma senha e verifique se ela atende às regras a seguir, exibindo se é válida ou inválida: solicitar a senha, verificar se possui pelo menos 8 caracteres, pelo menos um número e pelo menos uma letra maiúscula, e exibir o resultado.
Ferramentas novas para este exercício:
- `minhaString.Length` — quantidade de caracteres da string.
- `char.IsDigit(c)` — verifica se o caractere `c` é um número.
- `char.IsUpper(c)` — verifica se o caractere `c` é uma letra maiúscula.

---

## Recapitulando

Nesta aula, vimos:

- Operadores relacionais (`>`, `<`, `>=`, `<=`, `==`, `!=`), que sempre retornam um `bool`.
- Operadores lógicos (`&&`, `||`, `!`) e a tabela-verdade de cada um.
- A estrutura de decisão `if`/`else`, e o fato de que o `else` é opcional.
- Todos os casos de sintaxe do `if`/`else`, com linha única e com blocos.
- Decisão encadeada (`else if`), decisão aninhada, e a estrutura `switch`.
- Prática com 6 exercícios aplicando tudo isso.

**Próxima aula:** Estrutura de Repetição.