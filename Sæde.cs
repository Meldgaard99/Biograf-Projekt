using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul08
{
    internal class Sæde
    {

        public int RækkeNummer { get; set; }
        public int SædeNummer { get; set; }
        public bool SeatIsReserved { get; set; }



        public Sæde(int rækkeNummer = 0, int sædeNummer = 0, bool seatIsReserved = false)
        {
            this.RækkeNummer = rækkeNummer;
            this.SædeNummer = sædeNummer;
            this.SeatIsReserved = seatIsReserved;
        }
        override public String ToString()
        {
            return $" Rækkenummer = {RækkeNummer}, Sædenummer = {SædeNummer}, reserveret = {SeatIsReserved}";
        }
    }
}
