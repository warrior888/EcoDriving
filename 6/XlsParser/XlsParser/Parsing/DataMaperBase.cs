using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XlsParser.Parsing
{
    /*
     * fo9r the t3 type please add a logic of opening the file and parsing only the column names, with this we can decide on the fly wchich parser do we need
     */ 
    public abstract class DataMaperBase<T, T2, T3>
    {
        public abstract T getModelData(T2 queryFactory);
        // ExcelQueryFactory
        public abstract T getAdequateParser(T3 queryFactory); // most likely T2 is enough for us to implement this method (cheers MG8)
    }
   
}
