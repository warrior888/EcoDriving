using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExample
{
    public class DNA: ChemicalSubstance<DNA>
    {
        public int molecule;


        public DNA()
        {
            this.tConverter = new Dictionary<string, string>
            {
            {"godSection", DnaGodSection(this)},
            };
        }

        private string DnaGodSection(DNA dna)
        {
            return "action ....";
        }

        public string Parser(DNA section, string sectionName)
        {
            if (this.tConverter.ContainsKey(sectionName))
            {
                return this.tConverter[sectionName];
            }

            return "";
        }
    }
}
