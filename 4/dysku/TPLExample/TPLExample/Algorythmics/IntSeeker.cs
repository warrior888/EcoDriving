using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TPLExample.Algorythmics
{
    public class IntSeeker
    {
        private static object locker = new object();
        private int count = 0;  //chronione tylko przy dziedziczeniu, jakbysmy chcieli dziedziczyc
        /*public int intMatcher(List<int> list, int seekValue)
        {
            int count = 0;
            foreach(var item in list)
            {

                if (item == seekValue)
                {
                    count++;
                }

                
            }
            return count;
        }*/

        /* public int intMatcher(List<int> list, int seekValue)//LINQ
        {
       return list.Count(item => item == seekValue)
         }*/

        public int intMatcher(List<int> list, int seekValue, int numberOfThreads)//LINQ
        {
            count = 0;
           list.AsParallel().WithDegreeOfParallelism(numberOfThreads).ForAll((item) => compareAndCount(seekValue, item));//lambda, zawsze jest voidowe bo leci na wielu watkach
           return count;
        }

        private void compareAndCount(int seekValue, int item)
        {
            
            if (item == seekValue)
            {
                lock (locker)
                {
                    count++;
                }
            }
          
        }
    }
}
//zrobic to na genericsach na texcie, generyczne klasy, randomizer textowy
//semafor bitowy