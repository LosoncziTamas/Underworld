using System;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    private static readonly int Walking = Animator.StringToHash("IsWalking");
    private static readonly int Turning = Animator.StringToHash("Turning");

    [SerializeField] private Animator _animator;
    [SerializeField] private PlayerInput _playerInput;
    [SerializeField] private float _rotationSpeed;
    [SerializeField] private float _movementSpeed;
    
    private Transform _transform;

    private void Start()
    {
        _transform = gameObject.transform;
    }

    private void Update()
    {
        var moving = false;
        var rotation = 0;
        if (_playerInput.Left)
        {
            rotation = -1;
            _transform.Rotate(Vector3.up, -_rotationSpeed * Time.deltaTime, Space.Self);
        }
        if (_playerInput.Right)
        {
            rotation = 1;
            _transform.Rotate(Vector3.up, _rotationSpeed * Time.deltaTime, Space.Self);
        }
        if (_playerInput.Forward)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * _movementSpeed, Space.Self);
            moving = true;
        }
        if (_playerInput.Backward)
        {
            transform.Translate(Vector3.back * Time.deltaTime * _movementSpeed, Space.Self);
            moving = true;
        }
        _animator.SetBool(Walking, moving);
        _animator.SetInteger(Turning, rotation);

    }
}
