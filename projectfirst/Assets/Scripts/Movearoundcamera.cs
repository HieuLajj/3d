using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movearoundcamera : MonoBehaviour
{
    [SerializeField]
    private float _move =3.0f;
    private float _rotationX;
    private float _rotationY;
    [SerializeField] private Transform _target;
    [SerializeField] private float _distanceFromTarget = 5.0f;
    private Vector3 _currentRotation;
    private Vector3 smoothVelocity = Vector3.zero;
    private float smoothTime = 0.2f;
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X")*_move;
        float mouseY = Input.GetAxis("Mouse Y")*_move;
        _rotationX +=mouseX;
        _rotationY -= mouseY;
        Vector3 nextRotation = new Vector3(_rotationY,_rotationX);
        _currentRotation = Vector3.SmoothDamp(_currentRotation, nextRotation,ref smoothVelocity, smoothTime);
        transform.localEulerAngles = _currentRotation;
       // transform.position = _target.position - transform.forward* _distanceFromTarget;
        
    }
}
