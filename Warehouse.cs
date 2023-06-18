using System;
using System.Collections.Generic;

namespace napilnikShop2
{
    public class Warehouse
    {
        private Dictionary<Good, int> _goods = new Dictionary<Good, int>();

        public void Delive(Good good, int count)
        {
            if(_goods.ContainsKey(good) == true)
            {
                _goods[good] += count;
            }
            else
            {
                _goods.Add(good, count);
            }
        }

        public void OutputLeftovers()
        {
            foreach (var good in _goods)
            {
                Console.WriteLine(good.Key.Name, good.Value);
            }
        }

        public bool CompareLeftovers(Good good, int value)
        {
            if(_goods.ContainsKey(good) && _goods[good] >= value)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void TransferCart(Good good, int count)
        {
            _goods[good] -= count;
        }
    }
}