using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GhostRider.DatabaseAccess.DAL
{
   public abstract class DbCommand<T> //update, insert, delete
   {
       protected abstract string RenderInsert(T commandData);
       protected abstract string RenderUpdate(T commandData);
       protected abstract string RenderDelete(T commandData);
   }
}
