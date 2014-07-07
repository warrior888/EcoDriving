using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExample.Easy
{
   public class TransferTextFileParser : TransferParser<string>
   {
       private const char recordDelimiter = ';';
       private const char wordDelimiter = ',';
       private string fileName = "D:\\praca\\nowy potencjal\\szkolenie\\Dropbox\\Szkolenie\\level 3\\9\\GenericsExample\\przelewy.txt";

       protected override TransferRecord getTransferRecord(string record)
       {
           string[] splitTab = record.Split(wordDelimiter);
           TransferRecord TRrecord = new TransferRecord();
           if (splitTab.Length == 5)
           {
               TRrecord.TransferSource = splitTab[0].Trim();
               TRrecord.SourceAccountNumber = splitTab[1].Trim();
               TRrecord.TargetAccountNumber = splitTab[2].Trim();
               TRrecord.SourceName = splitTab[3].Trim();
               TRrecord.TargetName = splitTab[4].Trim();
           }


           return TRrecord; 
       }

       public void ParseTransfers()
       {
           
           StreamReader reader = new StreamReader(fileName);
           string file = reader.ReadToEnd();
           string[] splitTab = file.Split(recordDelimiter);
           
           doAllTransfers(splitTab);
       }


   }
}
