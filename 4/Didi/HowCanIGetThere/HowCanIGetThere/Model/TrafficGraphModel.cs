using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Graph;

namespace HowCanIGetThere.Model
{
    class TrafficGraphModel<T> : TrafficGraph<T> 
    {
        public TrafficGraphModel
            (
        
            string name,
            double cordinateX,
            double cordinateY,
            Dictionary<string, CommunicationSource> avaiable,
            TrafficGraph<T> neighbour
    

              )
        {
            this.name = name;
            this.coordinateX = cordinateX;
            this.coordinateY = cordinateY;
            this.avalibleCommunicationSources = avaiable;

            if (!neighbour.self.neighbours.ContainsKey(neighbour.self.name))
            {
               this.neighbours.Add(name, this); // te który aktualnie robimy 
            }
        }

      
        public TrafficGraphModel //przeciążamy 
            (

            string name,
            double cordinateX,
            double cordinateY
           

              )
        {
            this.name = name;
            this.coordinateX = cordinateX;
            this.coordinateY = cordinateY;
            this.self = this; 
        }
         

        protected override Graph<T> createNode(string name)
        {
            throw new NotImplementedException();
        }

        protected override Graph<T> createNode(Graph<T> node)
        {
            throw new NotImplementedException();
        }
    }
}
