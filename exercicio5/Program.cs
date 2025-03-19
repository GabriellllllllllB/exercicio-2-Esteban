
int media = 0;
int i;
int n;

Console.WriteLine("escreva quantos numeros seram lidos:");
n = int.Parse(Console.ReadLine());

int[] vetor = new int[n];

for (i = 0; i < n; i++)
{
    Console.WriteLine("escreva seus numeros:");
    vetor[i] = int.Parse(Console.ReadLine());

    if (vetor[i] % 2 == 0)
    {
        media = vetor.Sum() / n;
    }
}
Console.WriteLine($"media dos numeros pares:{media.ToString("F1")}");