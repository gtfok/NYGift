﻿using NYGift.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NYGift.Classes
{
    public class Gift : INYGift
    {
        private ICollection<ISweetness> sweetnessitems;
        public IEnumerable<ISweetness> Items
        {
            get { return sweetnessitems; }
        }
        public string GiftName { get; }
        public Gift(string name, ICollection<ISweetness> items)
        {
            sweetnessitems = items;
            GiftName = name;
        }
        public void AddSweet(Sweet sweet)
        {
            sweetnessitems.Add(sweet);
        }
        public void RemoveSweet(Sweet sweet)
        {
            sweetnessitems.Remove(sweet);
        }
        public int CountOfSweet
        {
            get { return sweetnessitems.Count(); }
        }
        public double GiftWeight
        {
            get
            {
                if (sweetnessitems != null)
                {
                    return sweetnessitems.Sum(x => x.Weight);
                }
                else
                {
                    //реализовать обработку исключения
                    throw new InvalidOperationException("Container in Gift cannot be null");
                }
            }
        }

        public string NameOfGift => throw new NotImplementedException();

        public IEnumerable<ISweetness> SortSweetnessByWeight()
        {
            //сделать универсальным (можно добавить вспомогательный класс)
            var temp = sweetnessitems.OrderBy(x => x.Weight).ToArray();
            return temp;
        }
        public IEnumerable<ISweetness> FindSweetnessBySugar(int min, int max)
        {

            return sweetnessitems.Where(x => (x.SugarPerUnit >= min) && (x.SugarPerUnit <= max)).ToList();

        }

        public IEnumerable<ISweetness> FindSweetnessBySugar(double min, double max)
        {
            throw new NotImplementedException();
        }

        public void DelSweet(Sweet sweets)
        {
            throw new NotImplementedException();
        }
    }
}