using System;

namespace InheritanceAndInterfaces
{
   public class BookModel : InventoryItemModel, IPurchasable  // Buy only
   {
      public int NumberOfPages { get; set; }

      public void Purchase()
      {
         QuantityInStock -= 1;
         Console.WriteLine("This book has been purchased");
      }
   }
}
