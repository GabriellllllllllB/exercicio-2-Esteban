int n;
int i;
int idade;
int maisve = 0;
string nomemaisve = "";
string nome;
string[]nomeidade;

Console.WriteLine("escreva quantos numeros seram lidos:");
n = int.Parse(Console.ReadLine());

int[] vetor = new int[n];

for (i = 0; i < n; i++)
{
    Console.WriteLine("escreva o nome e idade");
    nomeidade = Console.ReadLine().Split();
    nome = nomeidade[0];
    idade = int.Parse(nomeidade[1]);

    if (idade > maisve)
    {
        maisve = idade;
        nomemaisve = nome;
    }
}
Console.WriteLine($"o mais velho: {nomemaisve}");