using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XlsParser.Model
{
    public class EcoDrive : ModelBase
    {
        public string timeOfFrame { get; set; }
        public string auxAccelForward { get; set; }
        public string auxAccelLateral { get; set; }
        public string auxRotationRoll { get; set; }

    }
}
