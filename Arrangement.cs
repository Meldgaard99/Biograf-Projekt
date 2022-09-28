using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    internal class Arrangement
    {
        public string Navn { get; set; }
        public string ArrangementType { get; set; }
        public int ArrangementId { get; set; }
        
        public List<Sæde> Sæder = new List<Sæde>();

        public Arrangement(Sal sal, int maxRækker = 0, int maxSæder = 0, string navn = "", string arrangementType = "", int arrangementId = 0)
        {
            this.Navn = navn;
            this.ArrangementType = arrangementType;
            this.ArrangementId = arrangementId;
            LavSæder(sal);
        
            
        }

        

        public void LavSæder(Sal sal)
        {
            for (int i=1; i<=sal.MaxRækker; i++)
            {
                for(int f = 1; f <= sal.MaxSæder; f++)
                {
                    Sæde sæde = new Sæde(rækkeNummer:i, sædeNummer:f);
                    Sæder.Add(sæde);
                }
            }
        }

        

        

        
    }

