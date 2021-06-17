using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TankOfWar.PlayerMovement
{
    [CreateAssetMenu(menuName = "TankOfWar/Player/Movement Setting")]
    public class PlayerMovementSettings : ScriptableObject
    {
        public float HorizontalSpeeed = 5;
        public float VerticalSpeed = 5;


    }
}
