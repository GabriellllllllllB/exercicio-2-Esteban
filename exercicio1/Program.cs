﻿double n;
double x;
int i;
int pos = 0;
double m = 0;

Console.WriteLine("Digite seu numero");
n = double.Parse(Console.ReadLine());

for (i = 0; i < n; i++)
{
    Console.WriteLine("escreva o x");
    x = double.Parse(Console.ReadLine());

    if (x > m)
    {
        m = x;
        pos = i;

    }


}
Console.WriteLine(m.ToString("F1"));
Console.WriteLine(pos);