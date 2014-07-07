using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TPLExample.Algorythmics;

namespace TPLExample
{
   public class RandomizeAndSeek
    {
       public IntRandomizer randomizer = new IntRandomizer();

       public IntSeeker seeker = new IntSeeker();

       public int randomizeandSeek(int lenght, int min, int max, int seekValue, int numberOfThreads)
       {
           var list = randomizer.getRandomList(min, max, lenght, numberOfThreads);   //ctrl shift spacja - podpowiada
           var count = seeker.intMatcher(list, seekValue, numberOfThreads);

           return count;
       }
    }
}
