using System;

double media = 0;
int i;
string nome;
double nota1;
double nota2;

Console.WriteLine("escreva quantos alunos seram lidos:");
int n = int.Parse(Console.ReadLine());

List<string> alunosap = new List<string>();
for (i = 0; i < n; i++)
{
    Console.WriteLine("escreva o nome e a nota");
    string[] nomeNota = Console.ReadLine().Split();

    nome = nomeNota[0];
    nota1 = double.Parse(nomeNota[1]);
    nota2 = double.Parse(nomeNota[2]);

    media = (nota1 + nota2) / 2;


    if (media >= 6)
    {
        alunosap.Add(nome);
    }

}
Console.WriteLine($"alunos aprovados:");
foreach (var aluno in alunosap)
{
    Console.WriteLine(aluno);
}