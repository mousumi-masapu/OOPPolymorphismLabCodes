using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalPolymorphism
{
    class Cat : Animal
    {
        public Cat (string name,string favouritefood) :  base(name, favouritefood) 
        {
        
        }


    public override string ExplainSelf()
    {
        return $"{base.ExplainSelf()} {Environment.NewLine}MEEOW";
    }
    }
}
