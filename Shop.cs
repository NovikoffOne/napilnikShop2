using System;

namespace napilnikShop2
{
    public class Shop
    {
        private Cart _cart;
        private Warehouse _warehouse;

        public string Paylink => new Random().Next(100000000).ToString();

        public Shop(Warehouse warehouse) => _warehouse = warehouse;

        public Cart Cart()
        {
            _cart = new Cart(_warehouse, this);

            return _cart;
        }
    }
}