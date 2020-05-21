﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalPolymorphism
{
    class Dog: Animal
    {
        public Dog(string name, string favouriteFood) : base(name, favouriteFood)

        {

        }

        public override string ExplainSelf()

        {

            return $"{base.ExplainSelf()}{Environment.NewLine}DJAAF";

        }
    }
}
