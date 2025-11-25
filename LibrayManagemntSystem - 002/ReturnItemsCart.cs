using System.Collections.Generic;

namespace LibrayManagemntSystem
{
    internal class ReturnItemsCart
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

        public void ReturnAll()
        {
            foreach (var item in _items)
            {
                item.Stock++;
            }

            _items.Clear();
        }

        public void Clear()
        {
            _items.Clear();
        }
    }
}
