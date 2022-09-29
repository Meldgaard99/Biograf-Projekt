using System;
using System.Linq.Expressions;

//Class
internal class KundeReservation: Kunde {

    public int SalNr { get; set; }
    public int AntalPladserReserveret { get; set; }
    public DateTime ReservationDato { get; set; }
    public int ArrangementID { get; set; }

    public int ValgtSæde { get; set; }

    public int ValgtRække { get; set; }



// Constructor
// Mangler at lave constructor til datetime
    public KundeReservation(Arrangement arrangement, int salNr = 0, int antalPladserReserveret = 0, int arrangementID = 0 , int valgtSæde = 0, int valgtRække = 0){
        this.ValgtSæde = valgtSæde;
        this.ValgtRække = valgtRække; 
        SalNr = salNr;
        AntalPladserReserveret = antalPladserReserveret;
        ArrangementID = arrangementID;
        ReserverSæder(arrangement);

    }

    public void ReserverSæder(Arrangement arrangement){

        int sædeIndex = (ValgtRække-1)*4 + ValgtSæde -1;

        if (arrangement.Sæder[sædeIndex].SædeNummer == ValgtSæde && arrangement.Sæder[sædeIndex].RækkeNummer == ValgtRække && arrangement.Sæder[sædeIndex].SeatIsReserved == false){
            arrangement.Sæder[sædeIndex].SeatIsReserved = true;
        }
        else{
            Console.WriteLine("Desværre sæde reservert eller fejl indtasning");
        }

        /*
        foreach(Sæde s in arrangement.Sæder){
            if (ValgtSæde == s.SædeNummer && ValgtRække == s.RækkeNummer && s.SeatIsReserved == false){
                s.SeatIsReserved = true;
                AntalPladserReserveret++;
            }
        }
        */


    }


    // Metoder

    public override string ToString(){

        return $" Sal nr. = {SalNr}, Antal Reserverede pladser = {AntalPladserReserveret}, Tidspunkt for reservation: {ReservationDato}, ID for reservation {ArrangementID}";

    }



}


