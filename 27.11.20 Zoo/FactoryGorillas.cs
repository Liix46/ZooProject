﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27._11._20_Zoo
{
    class FactoryGorillas : IFactoryAnimals
    {
        public IAnimal CreateAnimal()
        {
            return new AnimalGorilla();
        }
    }
}
