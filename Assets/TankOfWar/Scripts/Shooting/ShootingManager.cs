using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace TankOfWar.Shooting
{
    public class ShootingManager : MonoBehaviour
    {
        public void Shoot(Vector3 from,Vector3 direction)
        {
            RaycastHit hit;
            bool rayHit = Physics.Raycast(transform.position, direction, 
                out hit, Mathf.Infinity);

            if (rayHit)
            {

            }
        }
    }
}
