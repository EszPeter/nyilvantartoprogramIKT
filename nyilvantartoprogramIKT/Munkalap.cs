using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace nyilvantartoprogramIKT
{
    public class Munkalap
    {

        string eszkozNev, hibaLeiras, statusz;
        int alkatreszekAra, munkadij;

        public Munkalap(string eszkozNev, string hibaLeiras, int alkatreszekAra, int munkadij, string statusz = "aktuális")
        {
            this.eszkozNev = eszkozNev;
            this.hibaLeiras = hibaLeiras;
            this.statusz = statusz;
            this.alkatreszekAra = alkatreszekAra;
            this.munkadij = munkadij;
        }

        public string EszkozNev { get => eszkozNev; set => eszkozNev = value; }
        public string HibaLeiras { get => hibaLeiras; set => hibaLeiras = value; }
        public string Statusz { get => statusz; }
        public int AlkatreszekAra { get => alkatreszekAra; }
        public int Munkadij { get => munkadij; }

        public void SetAlkatreszekAra(int UjAlkatreszekAra)
        {
            if (UjAlkatreszekAra > 0 )
            {
                alkatreszekAra = UjAlkatreszekAra;
            }
            else
            {
                throw new ArgumentException("Az alkatrészek ára nem lehet negatív!");
            }
        }

        public void SetMunkadij(int UjMunkadij)
        {
            if (UjMunkadij > 0)
            {
                munkadij = UjMunkadij;
            }
            else
            {
                throw new ArgumentException("A munkadíj nem lehet negatív!");
            }
        }
    }
}
