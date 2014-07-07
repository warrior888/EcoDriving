using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPLExample.Algorythmes
{
    public class IntRandomizer // TODO generic Randomizer<T> parent class should be implemented for more ambituous approach
    {
        Random random = new Random();
        List<int> list = new List<int>();
        private static object locker = new object();

        public int getRandomInt(int min, int max)
        {
            return random.Next(min, max);
        }
        public List<int> getRandomList (int min, int max, int lenght, int numberOfThreads)
        {
            List<Task> taskList = new List<Task>();
            int countPerThread = lenght/numberOfThreads; 

            // threadRandomGenerator(min, max, countPerThread);
            TaskFactory tf = new TaskFactory();
            for (int i = 0; i < numberOfThreads; i++)
            {
                taskList.Add(tf.StartNew(() => threadRandomGenerator(min, max, countPerThread)));
            }

            foreach (var item in taskList)
            {
                item.Wait();
            }

            return list;
        }


        private void threadRandomGenerator(int min, int max, int lenght)
        {
            for (int i = 0; i < lenght; i++)
            {
                lock (locker)
                {
                    list.Add(getRandomInt(min, max));
                }
            }
        }
    }
}
