using System;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    private static readonly int Walking = Animator.StringToHash("IsWalking");
    
    [SerializeField] private Animator _animator;
    [SerializeField] private PlayerInput _playerInput;
    [SerializeField] private float _rotationSpeed;
    
    private Transform _transform;

    private void Start()
    {
        _transform = gameObject.transform;
    }

    private void Update()
    {
        var moving = false;
        if (_playerInput.Left)
        {
            _transform.Rotate(Vector3.up, -_rotationSpeed * Time.deltaTime);
        }
        if (_playerInput.Right)
        {
            _transform.Rotate(Vector3.up, _rotationSpeed * Time.deltaTime);
        }
        if (_playerInput.Forward)
        {
            moving = true;
        }
        if (_playerInput.Backward)
        {
            moving = true;
        }
        _animator.SetBool(Walking, moving);

    }
}
