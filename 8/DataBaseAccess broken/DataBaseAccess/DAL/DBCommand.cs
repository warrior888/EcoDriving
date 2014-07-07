using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GhostRider.DataBaseAccess.DAL
{
    public abstract class DBCommand<T> // update, insert and delete
    {
        protected abstract string renderInsert(T commandData);
        protected abstract string renderUpdate(T commandData);
        protected abstract string renderDelete(T commandData);
    }
}
