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

            if (Input.GetKeyDown(KeyCode.Space))
            {

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
            _cameraTranform.localPosition = _cameraSettings.PositionOffset;
        }
    }
}