using System;
using System.Text;

public class Biograf{

    public string Navn { get; set; }

    
    public Biograf(string navn = ""){
        Navn = navn;
    }


    override public String ToString(){
        return $" Navn = {Navn}";
    }

}




