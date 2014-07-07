using System;
using System.Collections.Generic;
using InterfaceExtension.Interface;
using System.Linq;

namespace InterfaceExtension
{
    public class Rose : IFlower, IPlant
    {
        public void Test()
        {
            throw new System.NotImplementedException();
        }

        public int Test2()
        {
            throw new System.NotImplementedException();
        }


        public bool Bloom()
        {
            throw new System.NotImplementedException();
        }

        public void ReSharperShowDown()
        {
            var ExampleList = new Dictionary<string, int>
            {
                { "a", 2 },
                { "b", -1 },
                { "c", 2 },
                { "d", -1 },
                { "e", 2 },
            };

            foreach (var exampleItem in ExampleList)
            {
                //ExampleList[exampleItem.Key] += 3;
                Console.WriteLine("Bierzaca wartosc: {0} {1}", exampleItem.Key, exampleItem.Value);
            }

            var keys = ExampleList.Keys.ToArray();

            for (int i = 0; i < ExampleList.Count; i++)
            {
                ExampleList[keys[i]] += 3;
                Console.WriteLine("Bierzaca wartosc: {0}", ExampleList[keys[i]]);
            }

            var selected = ExampleList.AsEnumerable().Select(item => item).Where(
                delegate(KeyValuePair<string, int> item) { return item.Value == 2; });
        }



        // public Func<KeyValuePair<string, int>, bool> delegat(KeyValuePair<string, int> item)
        

        public bool Funkcja(KeyValuePair<string, int> item)
        {
            return item.Value == 2;
        }
    }
}
