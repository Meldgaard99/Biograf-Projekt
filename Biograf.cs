using System;
using System.Text;

public class Biograf
{
    public string Navn { get; set; }


    List<Sal> Autoværksted = new List<Sal>();
    List<kunde> Autoværksted2 = new List<Kunde>();
    List<Arrangement> Autoværksted3 = new List<Arrangement>();

    f
    public Biograf(string Navn = "")
    {
        Navn = Navn;

    }


    override public String ToString()
    {
        return $" Navn = {Navn}";
    }

}




