using System;

//Class
internal class KundeReservation: Kunde 
    {

    public int SalNr { get; set; }
    public int AntalPladserReserveret { get; set; }
    public DateTime ReservationDato { get; set; }
    public int ArrangementID { get; set; }


// Constructor
// Mangler at lave constructor til datetime
    public KundeReservation( int salNr = 0, int antalPladserReserveret = 0, int arrangementID = 0 )
    {

        SalNr = salNr;
        AntalPladserReserveret = antalPladserReserveret;
        ArrangementID = arrangementID;
        //ReserverSæder(Arrangement);

    }

    /*public void ReserverSæder(Arrangement arrangement)
    {

    }*/ 


    // Metoder

    public override string ToString()
    {
        return $" Sal nr. = {SalNr}, Antal Reserverede pladser = {AntalPladserReserveret}, Tidspunkt for reservation: {ReservationDato}, ID for reservation {ArrangementID}";

    }



}


