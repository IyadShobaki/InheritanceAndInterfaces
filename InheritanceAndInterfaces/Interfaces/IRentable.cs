﻿namespace InheritanceAndInterfaces
{
   public interface IRentable : IInventoryItem
   {
      void Rent();
      void ReturnRental();
   }
}
