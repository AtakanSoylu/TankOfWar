using System.Collections;
using System.Collections.Generic;
using TankOfWar.Shooting;
using UnityEngine;

namespace TankOfWar.Camera
{
    public class CameraController : MonoBehaviour
    {
        [SerializeField] private CameraSettings _cameraSettings;
        [SerializeField] private Transform _targetTranform;
        [SerializeField] private Transform _cameraTranform;

        //test
        public ShootingManager _shootingManager;

        private void Update()
        {
            CameraRotationFollow();
            CameraMovementFollow();

            if (Input.GetKeyDown(KeyCode.U))
            {
                Debug.Log(_cameraTranform.right);
                Debug.Log(_cameraTranform.up);
                Debug.Log(_cameraTranform.forward);
            }
            if (Input.GetKeyDown(KeyCode.Space))
            {
                _shootingManager.Shoot(_cameraTranform.position, _cameraTranform.forward);
            }
        }

        private void CameraRotationFollow()
        {
            _cameraTranform.rotation = Quaternion.Lerp(_cameraTranform.rotation,
                Quaternion.LookRotation(_targetTranform.forward),
                Time.deltaTime * _cameraSettings.RotationLerpSpeed);
        }

        private void CameraMovementFollow()
        {
            Vector3 offset = (_cameraTranform.right * _cameraSettings.PositionOffset.x) 
                + (_cameraTranform.up * _cameraSettings.PositionOffset.y) 
                + (_cameraTranform.forward * _cameraSettings.PositionOffset.z);
            _cameraTranform.position = Vector3.Lerp(_cameraTranform.position,_targetTranform.position + offset,
                Time.deltaTime * _cameraSettings.PositionLerp);
        }
    }
}