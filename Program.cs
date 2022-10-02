using System;



Sal sal1 = new Sal(maxRækker: 2, maxSæder: 4);
Sal sal2 = new Sal(maxRækker: 5, maxSæder: 10);
Sal sal3 = new Sal(maxRækker: 10, maxSæder: 10);

Arrangement arrangement1 = new Arrangement(sal1);
Arrangement arrangement2 = new Arrangement(sal2);
Arrangement arrangement3 = new Arrangement(sal3);





Console.WriteLine("Hej og velkommen til Bezzo's biograf");
Console.WriteLine("Du har følgende muligheder:");
Console.WriteLine("Tast 1 for at se oversigt over sal 1: " );
Console.WriteLine("Tast 2 for at se oversigt over sal 2: ");
Console.WriteLine("Tast 3 for at se oversigt over sal 3: ");
Console.WriteLine("Tast 4 for at booke billetter:  ");




int OversigtNr = int.Parse(Console.ReadLine()!);


bool OversigtBool = true; //Laver en bool

while (OversigtBool == true) //Så længe den er true kør den.
{


    switch (OversigtNr)

    {
        case 1:
            Console.Clear();
            arrangement1.Sæder.ForEach(Console.WriteLine);
                OversigtBool = false;

            
            break;


        case 2:
            Console.Clear();
            arrangement2.Sæder.ForEach(Console.WriteLine);
             OversigtBool = false;


            break;

        case 3:
            Console.Clear();
            arrangement3.Sæder.ForEach(Console.WriteLine);
            OversigtBool = false;


            break;





        case 4:
        default:

            {
                Console.WriteLine("Det er bare i orden ");
                Console.Clear();
                OversigtBool = false;
                break;
            }





    }
}





Console.WriteLine("Indtast dit fornavn: ");
string BrugerFornavn = Console.ReadLine()!;

Console.WriteLine($"Indat nu dit efternavn, {BrugerFornavn}: " );
String BrugerEfternavn = Console.ReadLine()!;
Console.Clear();


/*
skal kigges igennem, virker ikke
Console.WriteLine("vælg sal");
int BrugerValgtSal = int.Parse(Console.ReadLine()!);


Sal salvalg = new Sal(valgtsal: BrugerValgtSal);
Console.WriteLine("Du nu valgt sal");
salvalg.ToString();

*/

Console.WriteLine($"Vælg række og sæde, {BrugerFornavn} {BrugerEfternavn} ");
int brugerValgtRække = int.Parse(Console.ReadLine()!);
int brugerValgtSæde = int.Parse(Console.ReadLine()!);


Console.WriteLine($"Række: {brugerValgtRække}, Sæde: {brugerValgtSæde}");



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



Console.WriteLine($"God fornøjelse {BrugerFornavn} {BrugerEfternavn}, Dine billetter er følgende {brugerValgtRække} Sæde = {brugerValgtSæde}");