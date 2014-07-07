using System;
using System.Collections.Generic;


namespace Graph
{
    public abstract class Graph<T> : multiThradedLinqWhateverDude<T>
    {
        public Graph<T> self; 
        public Dictionary<string, Graph<T>> neighbours = new Dictionary<string, Graph<T>>(); // List of neighbours, they include 
        /*
         * for trafic they inculde:
         - list of neighbours
         - count of visit, etc
         */
        public string name; // Bus Stop Name

        protected abstract Graph<T> createNode(string name);
        protected abstract Graph<T> createNode(Graph<T> node);

        protected abstract Graph<T> findParticularNode(string name);
    }
}
