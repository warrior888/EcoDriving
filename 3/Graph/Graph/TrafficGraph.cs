using System;
using System.Collections.Generic;
namespace Graph
{
    public abstract class TrafficGraph<T> : Graph<T>
    {
        public double coordinateX { get; set; }
        public double coordinateY { get; set; }
        public int visitCount = 0; // shows how does the brain remember or it is about making the decision to remember something, nzt will save at 8 time, however, it will force the brain to make sure 8 times something makes sense to remember
        public const int maxSwitches = 1;
        public Dictionary<string, CommunicationSource> avalibleCommunicationSources = new Dictionary<string, CommunicationSource>(); // 
        protected Dictionary<string, CommunicationSource> possiblyChosenCommunicationSources = new Dictionary<string, CommunicationSource>(); //list of current communicationTypes, possibly to use for customer 
        protected Dictionary<string, CommunicationSource> visitedCommunicationSources = new Dictionary<string, CommunicationSource>(); //list of current communicationTypes, possibly to use for customer 
        
        protected Dictionary<string, Dictionary<TrafficGraph<T>, Func<double, double, double, double, double>>> distanceBetweenNodes;

        protected Dictionary<TrafficGraph<T>, Func<double, double, double, double, double>> distanceOnCurrentNode;

        public Dictionary<string, TrafficGraph<T>> getTravelPath(string startStreetName, string endStringName)
        {
            var startStreetNode = (TrafficGraph<T>)findParticularNode(startStreetName);
            var endStretNode = findParticularNode(endStringName);
            return null;
        }

        protected override Graph<T> findParticularNode(string street)
        {

            //var corectNode = node[street].findParticularNode(node.name);
            return null; //node;
        }

        protected double countDistance(double x1, double y1, double x2, double y2)
        {
            return 8;
        }

    }
}
