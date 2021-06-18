using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TankOfWar.Stat
{
    public class HealthStat : MonoBehaviour
    {
        public float health = 100;

        public void TakeHarras(float damage)
        {
            health -= damage;
            Debug.Log("Health : " + health);
        }
    }
}
