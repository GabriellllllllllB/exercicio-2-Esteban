int n;
int i;
int a;
int b;
int c = 0;

Console.WriteLine("escreva quantas vezem seram lidos");
n = int.Parse(Console.ReadLine());

for (i = 0; i < n; i++)
{
    Console.WriteLine("escreva o valor a");
    a = int.Parse(Console.ReadLine());
    Console.WriteLine("escreva o valor b");
    b = int.Parse(Console.ReadLine());
    c = a + b;
    Console.WriteLine("soma de a+b:");
    Console.WriteLine(c);

}