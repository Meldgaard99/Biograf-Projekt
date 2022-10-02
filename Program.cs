using System;



Sal sal1 = new Sal(maxRækker: 2, maxSæder: 4);
Sal sal2 = new Sal(maxRækker: 5, maxSæder: 10);
Sal sal3 = new Sal(maxRækker: 10, maxSæder: 10);



Console.WriteLine("Indtast dit fornavn: ");
string BrugerFornavn = Console.ReadLine()!;

Console.WriteLine($"Indat nu dit efternavn, {BrugerFornavn}: " );
String BrugerEfternavn = Console.ReadLine()!;
Console.Clear();



Console.WriteLine($"Vælg række og sæde, {BrugerFornavn} {BrugerEfternavn} ");
int brugerValgtRække = int.Parse(Console.ReadLine()!);
int brugerValgtSæde = int.Parse(Console.ReadLine()!);


Console.WriteLine($"Række: {brugerValgtRække}, Sæde: {brugerValgtSæde}");

Arrangement arrangement1 = new Arrangement(sal1);

KundeReservation kundeReservation1 = new KundeReservation(arrangement: arrangement1, valgtRække: brugerValgtRække, valgtSæde: brugerValgtSæde);
Console.WriteLine("Du har nu reservet din plads");
kundeReservation1.ToString();


Console.Write("Vil du booke en billet mere, tast 1 for Ja og 2 for Nej:  ");



bool askUser = true; //Laver en bool

while (askUser == true) //Så længe den er true kør den.
{

    string UserInput = Console.ReadLine()!;

    switch (UserInput)

    {
        case "1":
            Console.Clear();
            askUser = false;

            break;


        case "2":
        default:

            {
                Console.WriteLine("Det er bare i orden ");
                Console.Clear();
                askUser = true;
                break;
            }


       
            
        
    }
}


while (1 > 0) {

    Console.WriteLine("Vælg række og sæde");
    int brugerValgtRække1 = int.Parse(Console.ReadLine()!);
    int brugerValgtSæde1 = int.Parse(Console.ReadLine()!);
    KundeReservation kundeReservation0 = new KundeReservation(arrangement: arrangement1, valgtRække: brugerValgtRække1, valgtSæde: brugerValgtSæde1);

    foreach (Sæde s in arrangement1.Sæder)
    {

        Console.WriteLine(s);

    }
}



foreach (Sæde s in arrangement1.Sæder){

    Console.WriteLine(s);
    
}

