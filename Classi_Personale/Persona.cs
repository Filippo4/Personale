using System;

namespace Classi_Personale
{
    public abstract class Persona
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string CodiceFiscale { get; set; }

        public Persona(string n,string c,string cdf)
        {
            Nome = n;
            Cognome = c;
            CodiceFiscale = cdf;
        }

        public override string ToString()
        {
            return $"{Nome}, {Cognome}";
        }
    }
}
