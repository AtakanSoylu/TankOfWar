using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using System;

namespace TankOfWar.Inventory
{
    [CreateAssetMenu(menuName = "TankOfWar/Inventory/Player Inventory Cannon Item Data")]
    public class PlayerInventoryCannonItemData : AbstractPlayerInventoryItemData<PlayerInventoryCannonItemMono>
    {
        [SerializeField] private float _damage;
        public float Damage { get { return _damage; } }

        [SerializeField] private float _rpm = 1f;
        public float Rpm { get { return _rpm; } }

        private float _lastShootTime;

        public override void Initialize(PlayerInventoryController targetPlayerInventory)
        {
            InstantiateAndInitializePrefab(targetPlayerInventory.Parent);
            targetPlayerInventory.ReactiveShootCommand.Subscribe(OnReactiveShootCommand).AddTo(_compositeDosposable);


        }

     
        public override void Destroy()
        {
            base.Destroy();
        }

        private void OnReactiveShootCommand(Unit obj)
        {
            Debug.Log("reactive command shoot");
            Shoot();
        }


        public void Shoot()
        {

            if (Time.time - _lastShootTime > _rpm)
            {
            _instantiated.Shoot();
            _lastShootTime = Time.time
            }
            else
            {
                Debug.Log("you cant shoot now");
            }

        }



    }
}
