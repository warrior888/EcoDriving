using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExample
{
    public class DNA: ChemicalSubstance<DNA>
    {
        public int molecue;
       
        public DNA()
        {
            this.tConverter = new Dictionary<string, string>
            {
                { "godsSection", DnsGodSection(this) },

            };
        }

        private string DnsGodSection(DNA dna)
        {
            return "Witam moje dzieci ....";
        }

        public string Parser(DNA section, string sectionName)
        {
            if (this.tConverter.ContainsKey(sectionName))
            {
                return this.tConverter[sectionName];
            }

            throw new Exception("That part is not known yet");
        }

        protected override DNA chemicalSubstanceStructure()
        {
            throw new NotImplementedException();
        }

        protected override void chemicalSubstanceStructureSave(DNA newStructure)
        {
            throw new NotImplementedException();
        }
    }
}
