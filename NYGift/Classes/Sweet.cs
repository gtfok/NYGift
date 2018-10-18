using NYGift.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NYGift.Classes
{
    public abstract class Sweet : ISweetness
    {
        public double SugarPerUnit { get; }
        public double Weight { get; }
        public string Name { get; }
       
        public abstract string TypeOfSweetness { get; }
        public abstract string ItemInfo { get; }

        public double Calories { get; }

        public Sweet(string name, double weight, double sugar, double calories)
        {
            Name = name;
            Weight = weight;
            SugarPerUnit = sugar;
            Calories = calories;
        }
    }
}
