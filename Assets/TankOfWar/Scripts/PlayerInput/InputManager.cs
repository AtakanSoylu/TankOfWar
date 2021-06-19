using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TankOfWar.PlayerInput
{
    public class InputManager : MonoBehaviour
    {
        [SerializeField] private InputData[] _inputDataArray;
        private void Update()
        {
            for(int i = 0; i < _inputDataArray.Length; i++)
            {
                _inputDataArray[i].ProcessInput();
            }


        }
    }
}
