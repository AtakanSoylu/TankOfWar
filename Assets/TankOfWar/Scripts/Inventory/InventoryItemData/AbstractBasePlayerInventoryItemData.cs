using System.Collections;
using UnityEngine;
using UniRx;

namespace TankOfWar.Inventory
{
    public abstract class AbstractBasePlayerInventoryItemData : ScriptableObject
    {

        private PlayerInventoryController _inventoryController;
        protected CompositeDisposable _compositeDosposable;

        public virtual void Initialize(PlayerInventoryController targetPlayerInventory)
        {
            _inventoryController = targetPlayerInventory;
        }

        public virtual void Destroy()
        {
            _compositeDosposable.Dispose();
            Destroy(this);
        }
        

    }
}