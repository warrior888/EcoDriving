using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExample.Easy
{
   public abstract class TransferParser<T>
   {


       protected T transferList { get; set; } 
       protected abstract TransferRecord getTransferRecord(T record);   //Zakładam że ta metoda ektraktuje pojedyncze metody przelewów, przetwarzanie sekwencyjne 

       protected bool doAllTransfers(T[] records)   //zapisanie do bazy danych
       {
           foreach (var record in records)
           {
               var transferRecord = getTransferRecord(record);
               transferRecord.SaveData();
           }
          
           return true;
       }
   }
}
