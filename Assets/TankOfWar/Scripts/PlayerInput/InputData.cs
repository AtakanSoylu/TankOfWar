using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TankOfWar.PlayerInput
{
    [CreateAssetMenu(menuName = "TankOfWar/Input/Input Data")]
    public class InputData : ScriptableObject
    {
        public float Horizontal;
        public float Vertical;


    }
}