using System;



Sal sal1 = new Sal(maxRækker: 2, maxSæder: 4);
Sal sal2 = new Sal(maxRækker: 5, maxSæder: 10);
Sal sal3 = new Sal(maxRækker: 10, maxSæder: 10);

Arrangement arrangement1 = new Arrangement(sal1);

List<Sal> listeAfSal = new List<Sal>();
listeAfSal.Add(sal1); listeAfSal.Add(sal2); listeAfSal.Add(sal3);
List<Arrangement> alleArrangementer = new List<Arrangement>();
alleArrangementer.Add(new Arrangement(sal: listeAfSal[0], navn: "SpiderMan"));
alleArrangementer.Add(new Arrangement(sal: listeAfSal[2], navn: "PeterPan"));


while (1 == 1) {
    Console.WriteLine("Hej og velkommen til Bezzo's biograf");
    Console.WriteLine("Er du ansat tryk 1 eller 2 for kunde");


    int OversigtNr = int.Parse(Console.ReadLine()!);

    switch (OversigtNr){


        case 1:
            Console.WriteLine("Hvilken film vil du gerne oprette?");
            string filmNavn = Console.ReadLine()!;
            Console.WriteLine("Hvilken sal vil du gerne booke til");
            int salNummer = 0;
            while (salNummer == 0)
            {
                try{
                    salNummer = Int16.Parse(Console.ReadLine()!);
                }
                catch{
                    Console.WriteLine("Du indtastede ikke et tal");
                    
                }
            }
            
            alleArrangementer.Add(new Arrangement(sal: listeAfSal[salNummer-1], navn: filmNavn));
            break;




        case 2:
            foreach (Arrangement aX in alleArrangementer){
                Console.WriteLine(aX.Navn, aX.angivetSal);
            }

            Console.WriteLine("Hvilken film vil du gerne booke til?");
            string valgtFilm = Console.ReadLine()!;
            bool userPickedMovie = false;
            while (userPickedMovie == false){
                foreach (Arrangement a1 in alleArrangementer){
                    if (a1.Navn.ToLower() == valgtFilm.ToLower())
                    {
                        userPickedMovie = true;
                        bookBillet(a1);
                    }
                }
            }




            
            break;

        default:
            Console.WriteLine("Du har trykekt forkert - start forfra");
            Console.Clear();
            break;
            
    }

}


void bookBillet(Arrangement valgtArrangement){


    Console.WriteLine("Indtast dit fornavn: ");
    string BrugerFornavn = Console.ReadLine()!;

    Console.WriteLine($"Indat nu dit efternavn, {BrugerFornavn}: ");
    String BrugerEfternavn = Console.ReadLine()!;
    Console.Clear();

    valgtArrangement.Sæder.ForEach(Console.WriteLine);
    Console.WriteLine($"Vælg række og sæde, {BrugerFornavn} {BrugerEfternavn} ");
    int brugerValgtRække = int.Parse(Console.ReadLine()!);
    int brugerValgtSæde = int.Parse(Console.ReadLine()!);


    Console.WriteLine($"Række: {brugerValgtRække}, Sæde: {brugerValgtSæde}");

    KundeReservation kundeReservation1 = new KundeReservation(arrangement: valgtArrangement, valgtRække: brugerValgtRække, valgtSæde: brugerValgtSæde);
    Console.WriteLine("Du har nu reservet din plads ",brugerValgtRække, brugerValgtSæde);
    kundeReservation1.ToString();
    valgtArrangement.Sæder.ForEach(Console.WriteLine);

}



