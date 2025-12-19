using System;
using UnityEngine;

public class SpherePlayer : MonoBehaviour
{
    public SphereMovementButton buttonLeft, buttonRight, buttonUp, buttonDown;
    public float speed = 10.0f;

    private int _xDirection = 0, _zDirection = 0;
    private Rigidbody _rigidbody;

    private void OnEnable()
    {
        buttonLeft.OnButtonDown += OnButtonDown;
        buttonRight.OnButtonDown += OnButtonDown;
        buttonUp.OnButtonDown += OnButtonDown;
        buttonDown.OnButtonDown += OnButtonDown;

        buttonLeft.OnButtonUp += OnButtonUp;
        buttonRight.OnButtonUp += OnButtonUp;
        buttonUp.OnButtonUp += OnButtonUp;
        buttonDown.OnButtonUp += OnButtonUp;
    }

    private void OnDisable()
    {
        buttonLeft.OnButtonDown -= OnButtonDown;
        buttonRight.OnButtonDown -= OnButtonDown;
        buttonUp.OnButtonDown -= OnButtonDown;
        buttonDown.OnButtonDown -= OnButtonDown;

        buttonLeft.OnButtonUp -= OnButtonUp;
        buttonRight.OnButtonUp -= OnButtonUp;
        buttonUp.OnButtonUp -= OnButtonUp;
        buttonDown.OnButtonUp -= OnButtonUp;
    }

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void OnButtonDown(SphereMovementButton.SphereDirection direction)
    {
        switch (direction)
        {
            case SphereMovementButton.SphereDirection.Up:
                _zDirection = 1;
                break;
            case SphereMovementButton.SphereDirection.Down:
                _zDirection = -1;
                break;
            case SphereMovementButton.SphereDirection.Left:
                _xDirection = -1;
                break;
            case SphereMovementButton.SphereDirection.Right:
                _xDirection = 1;
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(direction), direction, null);
        }
    }

    private void OnButtonUp(SphereMovementButton.SphereDirection direction)
    {
        _rigidbody.linearVelocity = Vector3.zero;
        _rigidbody.angularVelocity = Vector3.zero;
        
        _xDirection = 0;
        _zDirection = 0;
    }

    private void FixedUpdate()
    {
        Vector3 horizontalSpeed, verticalSpeed;

        if (_xDirection == 0)
            horizontalSpeed = Vector3.zero;
        else
            horizontalSpeed = _xDirection == -1 ? Vector3.left * speed : Vector3.right * speed;

        if (_zDirection == 0)
            verticalSpeed = Vector3.zero;
        else
            verticalSpeed = _zDirection == -1 ? Vector3.back * speed : Vector3.forward * speed;

        _rigidbody.AddForce(horizontalSpeed + verticalSpeed, ForceMode.Acceleration);
    }
}