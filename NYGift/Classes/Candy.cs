using NYGift.Enum;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NYGift.Classes

{
    public class Candy : Sweet
    {
        public TypeOfCandies TypeOfCandy;
        public Candy(string name, double weight, double sugar, double calories, TypeOfCandies typeOfCandy) : base(name, weight, sugar, calories)
        {
            TypeOfCandy = typeOfCandy;
        }
        public override string TypeOfSweetness => "Candy";
        public override string ItemInfo => string.Format(" {0},  weight: {1}, sugar: {2}, calories: {3}" + ", type of chocolste  {4} ", Name, Weight, SugarPerUnit, Calories, TypeOfCandy);
    }
}
