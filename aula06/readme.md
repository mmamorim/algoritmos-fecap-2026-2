![alt](../assets/banner.png)

# Aula 06 - 09/10/2026

# Arrays (vetores)

* Arrays (vetores) [Slides da Aula 06](./Aula06.pdf) 
* [Como usar o Spectre.Console](./spectre-console.md)


# Como fazer busca em Vetores (Arrays)?

O método Array.IndexOf no C# (.NET) serve para encontrar a posição (índice) da primeira ocorrência de um elemento dentro de um array.
* Se o elemento for encontrado, ele retorna o índice baseado em zero (0, 1, 2...).
* Se o elemento não for encontrado, ele retorna -1.

Exemplo Prático

~~~csharp
using System;

class Program
{
    static void Main()
    {
        // 1. Criando o array
        string[] carros = { "Fusca", "Brasília", "Chevette", "Brasília" };

        // 2. Buscando um elemento existente
        int indiceBrasilia = Array.IndexOf(carros, "Brasília");
        Console.WriteLine($"O primeiro 'Brasília' está no índice: {indiceBrasilia}"); 
        // Saída: 1

        // 3. Buscando a partir de um índice específico (para achar o segundo)
        int segundoBrasilia = Array.IndexOf(carros, "Brasília", 2);
        Console.WriteLine($"O segundo 'Brasília' está no índice: {segundoBrasilia}"); 
        // Saída: 3

        // 4. Buscando um elemento que não existe
        int naoEncontrado = Array.IndexOf(carros, "Ferrari");
        Console.WriteLine($"Índice da Ferrari: {naoEncontrado}"); 
        // Saída: -1
    }
}
~~~