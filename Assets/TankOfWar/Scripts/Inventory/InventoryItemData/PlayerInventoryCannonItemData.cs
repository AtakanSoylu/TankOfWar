using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TankOfWar.Inventory
{
    [CreateAssetMenu(menuName = "TankOfWar/Inventory/Player Inventory Cannon Item Data")]
    public class PlayerInventoryCannonItemData : AbstractPlayerInventoryItemData<PlayerInventoryCannonItemMono>
    {
        public override void CreateIntoInventory(PlayerInventoryController targetPlayerInventory)
        {
            var inisantiated = InstantiateAndInitializePrefab(targetPlayerInventory.Parent);

            Debug.Log("THIS CLASS IS CANNON ITEM DATA");
        }
    }
}
