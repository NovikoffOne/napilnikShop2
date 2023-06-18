using System;
using System.Collections.Generic;

namespace napilnikShop2
{
    public class Cart
    {
        private Warehouse _warehouse;
        private Shop _shop;

        private Dictionary<Good, int> _goods = new Dictionary<Good, int>();

        public Cart(Warehouse warehouse, Shop shop)
        {
            _warehouse = warehouse;
            _shop = shop;
        }

        public void Add(Good good, int value)
        {
            if (_goods.ContainsKey(good) == true && _warehouse.CompareLeftovers(good, value) == true)
            {
                _goods[good] += value;
            }
            else if (_warehouse.CompareLeftovers(good, value) == true)
            {
                _goods.Add(good, value);
            }
            else 
            {
                Console.WriteLine("Товара недостаточно");
                return;
            }
        }

        public Shop Order()
        {
            foreach (var good in _goods)
            {
                _warehouse.TransferCart(good.Key, good.Value);
                Console.WriteLine($"{good.Key.Name} - {good.Value} готов к оплате");
            }

            return _shop;
        }
    }
}