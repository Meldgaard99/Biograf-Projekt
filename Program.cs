using System;



Sal sal1 = new Sal(maxRækker: 10, maxSæder: 5);
Sal sal2 = new Sal(maxRækker: 5, maxSæder: 10);
Sal sal3 = new Sal(maxRækker: 10, maxSæder: 10);

Console.WriteLine("Vælg række og sæde");
int valgtRække = int.Parse(Console.ReadLine());
int valgtSæde = int.Parse(Console.ReadLine());

Console.WriteLine($"Række: {valgtRække}, Sæde: {valgtSæde}");



Arrangement arrangement1 = new Arrangement(sal1);


foreach (Sæde s in arrangement1.Sæder)
{
    Console.WriteLine(s);
}

