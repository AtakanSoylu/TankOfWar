using System.Collections;
using UnityEngine;

namespace TankOfWar.Inventory
{
    [CreateAssetMenu(menuName = "TankOfWar/Inventory/Player Inventory Body Item Data")]

    public class PlayerInventoryBodyItemData : AbstractPlayerInventoryItemData<PlayerInventoryBodyItemMono>
    {
        public override void Initialize(PlayerInventoryController targetPlayerInventory)
        {
            var inisantiated = InstantiateAndInitializePrefab(targetPlayerInventory.Parent);
        }
    }
}