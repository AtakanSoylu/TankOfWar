using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TankOfWar.Camera
{
    public class CameraController : MonoBehaviour
    {
        [SerializeField] private CameraSettings _cameraSettings;
        [SerializeField] private Transform _targetTranform;
        [SerializeField] private Transform _cameraTranform;

        private void Update()
        {
            CameraRotationFollow();
            CameraMovementFollow();
        }

        private void CameraRotationFollow()
        {
            _cameraTranform.rotation = Quaternion.Lerp(_cameraTranform.rotation,
                Quaternion.LookRotation(_targetTranform.position - _cameraTranform.position),
                Time.deltaTime * _cameraSettings.RotationLerpSpeed);
        }

        private void CameraMovementFollow()
        {
            _cameraTranform.position = Vector3.Lerp(_cameraTranform.position,
                _targetTranform.position + _cameraSettings.PositionOffset,
                Time.deltaTime * _cameraSettings.PositionLerp);
        }





    }
}