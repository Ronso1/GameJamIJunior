using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SystemOfPickUp : MonoBehaviour
{
    [SerializeField] private LayerMask _pickUpMask;
    [SerializeField] private Camera _playerCamera;
    [SerializeField] private Transform _targetPickUp;

    [SerializeField] private float _pickUpRange;
    private Rigidbody _currentObject;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (_currentObject)
            {
                _currentObject.useGravity = true; 
                _currentObject = null;
                return;
            }
            Ray CameraRay = _playerCamera.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
            if (Physics.Raycast(CameraRay, out RaycastHit HitInfo, _pickUpRange, _pickUpMask))
            {
                _currentObject = HitInfo.rigidbody;
                _currentObject.useGravity = false;

            }
        }
    }

    private void FixedUpdate()
    {
        if (_currentObject)
        {
            Vector3 DirectionToPoint = _targetPickUp.position - _currentObject.position;
            float DistanceToPoint = DirectionToPoint.magnitude;

            _currentObject.velocity = DirectionToPoint * 12f * DistanceToPoint;
        }
    }
}
