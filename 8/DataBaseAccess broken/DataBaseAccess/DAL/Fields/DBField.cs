using System;
using System.Collections.Generic;

namespace GhostRider.DataBaseAccess.DAL.Fields
{
   public abstract class DbField
   {
       protected DbField(object fieldValue)
       {
           this.FieldValue = fieldValue;
       }

       protected Dictionary<Type, string> surroundings = new Dictionary<Type, string>
       {
           { 8.GetType(), ""}, // int
           { 8.5.GetType(), ""}, // double
           { DateTime.Now.GetType(), "'"},
           { "siema Heniu".GetType(), "'"},
       };

       public virtual object FieldValue { get; set; } // 1, Dominika

       public string FieldName { get; set; }

       public override string ToString()
       {
           Type type = FieldValue.GetType();
           return string.Format("{0}{1}{0}", surroundings[type], FieldValue); // 'Dominika', 1
           // insert into (Id, Name, Bitrh) values (1, 'Domi', '1993-12-12 03:03:03')
       }
   }
}
