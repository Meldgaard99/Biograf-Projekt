﻿
using Modul08;

Sal sal1 = new Sal(maxRækker: 5, maxSæder: 5);



Arrangement arrangement1 = new Arrangement(sal1);

arrangement1.LavSæder();
foreach (Sæde s in arrangement1.Sæder)
{
    Console.WriteLine(s);
}