using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TPLExample.Algorythmes;

namespace TPLExample
{
    public class RandomizeAndSeek
    {
        public IntRandomizer randomizer = new IntRandomizer();
        public IntSeeker seeker = new IntSeeker();

        public int randomizeAndSeek(int lenght, int min, int max, int seekValue, int numberOfThreads)
        {
            var list  = randomizer.getRandomList(min,max, lenght, numberOfThreads);
            var count = seeker.intMatcher(list, seekValue, numberOfThreads);
            return count;
        }
    }
}
