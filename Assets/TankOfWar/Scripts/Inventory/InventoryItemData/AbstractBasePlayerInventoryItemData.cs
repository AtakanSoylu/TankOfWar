using System.Collections;
using UnityEngine;

namespace TankOfWar.Inventory
{
    public abstract class AbstractBasePlayerInventoryItemData : ScriptableObject
    {
        public abstract void CreateIntoInventory(PlayerInventoryController targetPlayerInventory);


    }
}