using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExample
{
    abstract public class ChemicalSubstance<T>
    {
        protected Dictionary<string, string> tConverter;

        protected abstract T ChemicalSubstanceStructure();
        protected abstract void ChemicalSubstanceStructureSave(T newStructure);


        public T ChemicalSubstanceBuilder()
        {
            var structure = ChemicalSubstanceStructure(); // in example strategy pattern of retrieving structure information from the database or xmpl or webservice or wcf...
            return structure;
        }

        public void ChemicalSubstanceSaver(T newStructure, Func<T, RNA> converter)
        {
            //please assume we can imagine some computations over here made on T that are done before data base save
            var RNA = converter(newStructure);
            rnaSave(RNA);


            ChemicalSubstanceStructureSave(newStructure);
        }

        private void rnaSave(RNA rna)
        { 
            //full data base save implementation
        }
    }
}
