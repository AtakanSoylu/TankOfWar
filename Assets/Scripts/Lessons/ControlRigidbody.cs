using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Lessons { 
    public class ControlRigidbody : MonoBehaviour
    {
        [SerializeField] private Rigidbody _rigidBody;
        [SerializeField] private ControlRigidbodySettings _settings;

        private void Update()
        {
            bool spaceKeyDown = Input.GetKeyDown(KeyCode.Space);
            if (spaceKeyDown)
            {
                _rigidBody.AddForce(_settings.JumpForce, ForceMode.Impulse);
            }
        }
    }
}
