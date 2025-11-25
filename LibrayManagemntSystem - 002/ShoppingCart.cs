using System.Collections.Generic;

namespace LibrayManagemntSystem
{
    internal class ShoppingCart
    {
        private readonly List<IInventoryItem> _items = new();

        public IReadOnlyList<IInventoryItem> Items => _items;

        public void AddItem(IInventoryItem item)
        {
            if (item != null)
            {
                _items.Add(item);
            }
        }

        public void Checkout()
        {
            foreach (var item in _items)
            {
                if (item.Stock > 0)
                {
                    item.Stock--;
                }
            }

            _items.Clear();
        }

        public void Clear()
        {
            _items.Clear();
        }
    }
}
