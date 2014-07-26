using System;
using System.Collections.Generic;

namespace GhostRider.DatabaseAccess.DAL.Fields
{
     public abstract class DbField
     {

         protected DbField(object fieldValue)
         {
             this.FieldValue = fieldValue;
         }

         //Type - int,string,datetime
         protected Dictionary<Type, String> surroundings = new Dictionary<Type, string>()
         {
             {8.GetType(), ""},//int
             {8.5.GetType(), ""}, //double
             {DateTime.Now.GetType(), "'"},
             {"siema Heniu".GetType(), "'"},

         };

         public virtual object FieldValue { get; set; }

         public string FieldName { get; set; }

         public override string ToString()
         {
             Type type;
             if (FieldValue == null)
             {
                 type = "8".GetType();
             }
             else
             {
                 type = FieldValue.GetType();
             }

             if (surroundings.ContainsKey(type))
             {
                 return string.Format("{0}{1}{0}", surroundings[type], FieldValue);
             }

             return string.Format("'{0}'", FieldValue);
             // insert into tabela (Id, Name, Birth) values (1, 'Domi', '1993-03-13 03:03:03')
         }


     }
}
