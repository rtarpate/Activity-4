using System;

namespace LibrayManagemntSystem
{
    // Common interface for anything with stock that can be shown in lists
    internal interface IInventoryItem
    {
        string GetDisplayInfo();
        int Stock { get; set; }
    }

    internal static class GlobalStates
    {
        // Shared library data (books + DVDs)
        public static LibraryManager Library { get; } = new LibraryManager();

        // Shared cart used by the RentAnItemForm
        public static ShoppingCart ShoppingCart { get; } = new ShoppingCart();

        // Shared cart used by the ReturnAnItemForm
        public static ReturnItemsCart ReturnItemsCart { get; } = new ReturnItemsCart();
    }
}
