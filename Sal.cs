using System;

    public class Sal 
    {
        public int MaxRækker { get; set; }
        public int MaxSæder  { get; set; }
        public int ValgtSal  { get; set; }



    public Sal(int maxRækker = 0, int maxSæder = 0, int  valgtsal = 0 )
        {
        MaxRækker = maxRækker;
        MaxSæder = maxSæder;
        ValgtSal = valgtsal; 
            
        }
    
         

    override public String ToString()
        {
            return $" MaxRækker = {MaxRækker}, MaxSæder = {MaxSæder},Reserverepladser = reserverPladser(), salFuld() ";
        }

    }




