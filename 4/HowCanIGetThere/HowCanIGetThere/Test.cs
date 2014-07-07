using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Graph;
using HowCanIGetThere.Model;

namespace HowCanIGetThere
{
    public class Test
    {
        public TrafficGraphModel<int> getRootNode(string name, double cX, double cY)
        {
            var node = new TrafficGraphModel<int>(name, cX, cY);

            return node;
        }

        public TrafficGraphModel<int> AddNode(TrafficGraphModel<int> neighbourNode, string name, double cX, double cY)
        {
            var node = new TrafficGraphModel<int>(name, cX, cY, null, neighbourNode);

            return node;
        }
    }
}
