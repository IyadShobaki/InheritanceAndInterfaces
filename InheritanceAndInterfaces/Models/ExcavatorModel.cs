using System;

namespace InheritanceAndInterfaces
{
   public class ExcavatorModel : InventoryItemModel, IRentable // Rent and return only
   {
      public void Dig()
      {
         Console.WriteLine("I am digging.");
      }

      public void Rent()
      {
         QuantityInStock -= 1;
         Console.WriteLine("This excavator has been rented");
      }

      public void ReturnRental()
      {
         QuantityInStock += 1;
         Console.WriteLine("This excavator has been returned");
      }
   }
}
