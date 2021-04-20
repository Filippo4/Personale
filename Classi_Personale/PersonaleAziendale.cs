using System;
using System.Collections.Generic;
using System.Text;

namespace Classi_Personale
{
    public class PersonaleAziendale :Persona
    {
        public string Tipologia { get; set; }
        public string Qualifica { get; set; }
        public string Area { get; set; }

        public PersonaleAziendale(string n,string c,string cdf,string tipologia): base(n,c,cdf)
        {
            Tipologia = tipologia;
        }
        public override string ToString()
        {
            return base.ToString() + $", {Tipologia}, {Qualifica}, {Area}";
        }
    }
}
