using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace TankOfWar.PlayerControls
{
    [CreateAssetMenu(menuName = "TankOfWar/Player/Tower Rotation Setting")]
    public class TowerRotationSettings : ScriptableObject
    {
        public float TowerRotationSpeed = 1;
    }
}
