using System;

namespace InheritanceAndInterfaces
{
   public class VehicleModel : InventoryItemModel, IPurchasable, IRentable  // Buy or (Rent and return)
   {
      public decimal DealerFee { get; set; }

      public void Purchase()
      {
         QuantityInStock -= 1;
         Console.WriteLine("This vehicle has been purchased");
      }

      public void Rent()
      {
         QuantityInStock -= 1;
         Console.WriteLine("This vehicle has been rented");
      }

      public void ReturnRental()
      {
         QuantityInStock += 1;
         Console.WriteLine("This vehicle has been returned");
      }
   }
}
