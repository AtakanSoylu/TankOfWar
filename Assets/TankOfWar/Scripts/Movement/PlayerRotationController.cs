using System.Collections;
using System.Collections.Generic;
using TankOfWar.PlayerInput;
using UnityEngine;

namespace TankOfWar.PlayerMovement
{
    public class PlayerRotationController : MonoBehaviour
    {
        [SerializeField] private InputData _inputData;
        [SerializeField] private Transform _tower;

        private void Update()
        {
            _tower.Rotate(0, _inputData.Horizontal, 0, Space.Self);
        }

    }
}
