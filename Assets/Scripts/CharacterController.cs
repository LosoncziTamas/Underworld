using UnityEngine;

public class CharacterController : MonoBehaviour
{
    private static readonly int X = Animator.StringToHash("X");
    private static readonly int Y = Animator.StringToHash("Y");

    [SerializeField] private Animator _animator;
    [SerializeField] private PlayerInput _playerInput;
    [SerializeField] private float _maxVelocityMagnitude;
    [SerializeField] private float _movementSpeed;
    
    private Transform _transform;
    private Vector3 _velocity;
    
    private void Start()
    {
        _transform = gameObject.transform;
    }

    private void Update()
    {
        var x = 0f;
        var y = 0f;
        if (_playerInput.Left)
        {
            _velocity += Vector3.left;
            x = -1.0f;
        }
        if (_playerInput.Right)
        {
            _velocity += Vector3.right;
            x = 1.0f;
        }
        if (_playerInput.Forward)
        {
            _velocity += Vector3.forward;
            y = 1.0f;
        }
        if (_playerInput.Backward)
        {
            _velocity += Vector3.back;
            y = -1.0f;
        }
        _velocity = Vector3.ClampMagnitude(_velocity, _maxVelocityMagnitude);
        // _transform.Translate(_velocity * Time.deltaTime * _movementSpeed, Space.Self);
        //_animator.SetFloat(X, x);
        //_animator.SetFloat(Y, y);
    }
}
