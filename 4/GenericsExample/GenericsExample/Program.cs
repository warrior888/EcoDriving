﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Engine<GenericPetrol<KindOfUsage<ChemicalSubstance<DNA>>>> entireEngine = new Engine<GenericPetrol<KindOfUsage<ChemicalSubstance<DNA>>>>();
            
        }
    }
}
