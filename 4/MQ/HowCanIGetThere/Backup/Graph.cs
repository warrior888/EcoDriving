using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Graph
{
    public abstract class Graph<T> : multiThradedLinqWhateverDude<T>
    {
        protected Dictionary<string, Graph<T>> node = new Dictionary<string, Graph<T>>(); // List of neighbours, they include 
        /*
         * for trafic they inculde:
         - list of neighbours
         - count of visit, etc
         */
        public string name; // Bus Stop Name

        protected abstract Graph<T> createNode(string name);
        protected abstract Graph<T> createNode(Graph<T> node);


    }
}
