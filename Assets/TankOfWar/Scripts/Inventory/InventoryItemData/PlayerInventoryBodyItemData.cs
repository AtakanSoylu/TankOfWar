﻿using System.Collections;
using UnityEngine;

namespace TankOfWar.Inventory
{
    [CreateAssetMenu(menuName = "TankOfWar/Inventory/Player Inventory Body Item Data")]

    public class PlayerInventoryBodyItemData : AbstractPlayerInventoryItemData<PlayerInventoryBodyItemMono>
    {
        public override void CreateIntoInventory(PlayerInventoryController targetPlayerInventory)
        {
            var inisantiated = InstantiateAndInitializePrefab(targetPlayerInventory.Parent);
            Debug.Log("THIS CLASS IS BODY ITEM DATA");
        }
    }
}