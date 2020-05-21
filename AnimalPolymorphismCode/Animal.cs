using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace AnimalPolymorphism
{
    class Animal
    {

        public string Name { get; protected set; }
        public string FavouriteFood { get; protected set; }

        protected Animal(string name ,string favouritefood )
        {
            this.Name = name;
            this.FavouriteFood = favouritefood;

        }

        public virtual string ExplainSelf()

        {
           
            return $"I am {this.Name} and my fovourite food is {this.FavouriteFood}";

        }

    }
}
