using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPLExample.Algorythmics
{
   public class IntRandomizer
    {

        List<int> list = new List<int>();
       Random random = new Random();
       private static object locker = new object();

       public int getRandomInt(int min, int max)
       { 
       return random.Next(min, max);
       }

    /*   public List<int> getRandomList(int min, int max, int lenght, int numberOfThreads)
       {
           List<int> list = new List<int>(); w next wrzucamy deklaracje na poziom klasy
          

           for (int i = 0; i < lenght; i++)
           {
               list.Add(getRandomInt(min, max));
           }

           return list;
       }*/

         public List<int> getRandomList(int min, int max, int lenght, int numberOfThreads)
       {
           List<Task> taskList = new List<Task>();
          int countPerThread = lenght / numberOfThreads;
             TaskFactory tf = new TaskFactory();

         for (int i=0; i<numberOfThreads; i++)
         {
            taskList.Add(tf.StartNew(() => threadRandomGenerator(min, max, countPerThread)));//przed strzalka jest deklaracja metody tu () bo parametry pochodza z gory, a po strzalce jest definicja - cialo
         }
             foreach(var item in taskList)
             {item.Wait();}

           return list;
       }


       private void threadRandomGenerator(int min, int max, int lenght)
       {
           for(int i =0; i<lenght; i++)
           {
               lock (locker)
               {
                   list.Add(getRandomInt(min, max));
               }
           }
       
       }
       
    }
}
