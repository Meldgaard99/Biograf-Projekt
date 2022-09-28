using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul08
{
    internal class Arrangement
    {
        public string Navn { get; set; }
        public string ArrangementType { get; set; }
        public int ArrangementId { get; set; }
        public int MaxRækker;
        public int MaxSæder;

        public List<Sæde> Sæder = new List<Sæde>();

        public Arrangement(int maxRækker = 0, int maxSæder = 0, string navn = "", string arrangementType = "", int arrangementId = 0)
        {
            this.Navn = navn;
            this.ArrangementType = arrangementType;
            this.ArrangementId = arrangementId;
            this.MaxRækker = Sal.MaxRækker;
            
        }

        

        public void LavSæder()
        {
            for (int i=1; i<=MaxRækker; i++)
            {
                for(int f = 1; f <= MaxSæder; f++)
                {
                    Sæde sæde = new Sæde(rækkeNummer:i, sædeNummer:f);
                    Sæder.Add(sæde);
                }
            }
        }

        

        

        
    }
}
