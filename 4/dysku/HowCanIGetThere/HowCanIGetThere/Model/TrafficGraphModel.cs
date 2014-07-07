using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Graph;
namespace HowCanIGetThere.Model
{
   public class TrafficGraphModel<T>: TrafficGraph<T>
    {
      

       public TrafficGraphModel(
           string name, 
           double coordinateX, 
           double coordinateY,
           Dictionary<string, CommunicationSource> avaliable,
           TrafficGraph<T> neighbour
           ) 
       {
           this.self = this;
           this.name = name;
           this.coordinateX = coordinateX;
           this.coordinateY = coordinateY;
           this.avalibleCommunicationSources = avaliable;

           if (!neighbour.self.neighbours.ContainsKey(neighbour.self.name))
           {
               this.neighbours.Add(name, this);
           }
       }

       public TrafficGraphModel(
          string name,
          double coordinateX,
          double coordinateY
          ) 
       {
           this.self = this;
           this.name = name;
           this.coordinateX = coordinateX;
           this.coordinateY = coordinateY;
           
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
