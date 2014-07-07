using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XlsParser.Model
{
    public class Person : ModelBase
    {
        public int userId { get; set; }
        public string userName { get; set; }
        public string userLastName { get; set; }
    }
}
