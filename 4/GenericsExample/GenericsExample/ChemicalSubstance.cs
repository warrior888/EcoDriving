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
       protected abstract T chemicalSubstanceStructure();
       protected abstract void chemicalSubstanceStructureSave(T newStructure);

       public T chemicalSubstanceBuilder()
       {
           var structure = chemicalSubstanceStructure(); // in example strategy patter of retriving structure information brom DB or .xml etc
           
           return structure;
       }

       public void chemicalSubstanceSaver(T newStructure, Func<T, RNA> converter)
       {
           //please assume we can imagine some computations over here, made on T that are done before data bese save, 
           var rna = converter(newStructure);
           rnaSave(rna);


           chemicalSubstanceStructureSave(newStructure);
       }

       private void rnaSave(RNA rna)
       {
           // full data base save implementation!
       }
   }
}
