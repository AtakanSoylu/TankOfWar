using System.Collections;
using System.Collections.Generic;
using TankOfWar.Stat;
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
                if (hit.transform.GetComponent<HealthStat>() != null)
                {
                    hit.transform.GetComponent<HealthStat>().TakeHarras(5);
                }
                Debug.Log(hit.transform.name);
            }
        }
    }
}
