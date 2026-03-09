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

        public Munkalap(string eszkozNev, string hibaLeiras, int alkatreszekAra, int munkadij,  string statusz="aktuális")
        {
            this.eszkozNev = eszkozNev;
            this.hibaLeiras = hibaLeiras;
            this.statusz = statusz;
            this.alkatreszekAra = alkatreszekAra;
            this.munkadij = munkadij;
        }
    }
}
