﻿int n;
int i;
int pares = 0;


Console.WriteLine("escreva quantos numeros:");
n = int.Parse(Console.ReadLine());


int[] vetor = new int[n];
for (i = 0; i < n; i++)
{
    Console.WriteLine("escreva seus numeros");
    vetor[i] = int.Parse(Console.ReadLine());
}


for (i = 0; i < n; i++)
{
    if (vetor[i] % 2 == 0)
    {
        Console.WriteLine($"par:{vetor[i]}");
        pares++;
    }
}
Console.WriteLine($"valores pares: {pares}");