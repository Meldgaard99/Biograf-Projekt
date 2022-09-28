using System;


// Class
    public class Kunde
    {

    public string Navn { get; set; }
    public string Adresse { get; set; }
    public int Telefon { get; set; }
    public string Email { get; set; }
    public List<KundeReservation> AntalReservationer = new List<KundeReservation>(); // Virker ikke?


// Constructor
        public Kunde(string navn = "", string adresse = "", int telefon = 0, string email = "" )
        {

        Navn = navn;
        Adresse = adresse;
        Telefon = telefon;
        Email = email;
     

        }

    // Metoder

    public override string ToString()
    {
        return $" Navn = {Navn}, Adresse = {Adresse}, Telefon = {Telefon}, Email = {Email}"; 

    }




}


