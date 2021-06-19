using System.Collections;
using System.Collections.Generic;
using TankOfWar.PlayerInput;
using UnityEngine;

namespace TankOfWar.PlayerControls
{
    public class PlayerMovementController : MonoBehaviour
    {
        [SerializeField] private InputData _inputData;
        [SerializeField] private Rigidbody _rigidBody;
        [SerializeField] private Transform _targetTransform;
        [SerializeField] private PlayerMovementSettings _playerMovementSettings;


        private void Update()
        {

            _rigidBody.MovePosition(_rigidBody.position + (_rigidBody.transform.forward * _inputData.Vertical * 
                _playerMovementSettings.VerticalSpeed));
            _targetTransform.Rotate(0, _inputData.Horizontal * _playerMovementSettings.HorizontalSpeeed, 0, Space.Self);
        }



    }
}
