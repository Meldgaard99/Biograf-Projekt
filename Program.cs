using System;



Sal sal1 = new Sal(maxRækker: 2, maxSæder: 4);
Sal sal2 = new Sal(maxRækker: 5, maxSæder: 10);
Sal sal3 = new Sal(maxRækker: 10, maxSæder: 10);

Console.WriteLine("Vælg række og sæde");
int brugerValgtRække = int.Parse(Console.ReadLine());
int brugerValgtSæde = int.Parse(Console.ReadLine());

Console.WriteLine($"Række: {brugerValgtRække}, Sæde: {brugerValgtSæde}");

Arrangement arrangement1 = new Arrangement(sal1);

KundeReservation kundeReservation1 = new KundeReservation(arrangement: arrangement1, valgtRække: brugerValgtRække, valgtSæde: brugerValgtSæde);





foreach (Sæde s in arrangement1.Sæder)
{
    Console.WriteLine(s);
}

