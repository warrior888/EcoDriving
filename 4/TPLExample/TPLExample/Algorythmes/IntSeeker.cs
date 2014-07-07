using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TPLExample
{
    public class IntSeeker
    {

            /*foreach (var item in list)
            {
                if (item == seekValue)
                {
                    count++;
                }
            }*/
        private static object locker = new object();
        private int count = 0;
        public int intMatcher(List<int> list, int seekValue, int numberOfThreads)
        {
            count = 0;
            list.AsParallel().WithDegreeOfParallelism(numberOfThreads).ForAll((item) => compareAndCount(seekValue, item));
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
