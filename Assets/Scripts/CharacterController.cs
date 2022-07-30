using UnityEngine;

public class CharacterController : MonoBehaviour
{
    private static readonly int Horizontal = Animator.StringToHash("Horizontal");
    private static readonly int Vertical = Animator.StringToHash("Vertical");

    [SerializeField] private Animator _animator;

    [SerializeField] private float _speed;
    private Transform _transform;
    private Vector3 _velocity;
    
    private void Start()
    {
        _transform = gameObject.transform;
    }

    private void FixedUpdate()
    {
        var horizontal = Input.GetAxis("Horizontal");
        var vertical = Input.GetAxis("Vertical");
        DebugGui.Instance.PrintLine($"horizontal {horizontal} vertical {vertical}");

        var offset = _transform.forward * vertical + _transform.right * horizontal;
        offset.Normalize();
        
        _transform.Translate(offset * 0.04f);
        _animator.SetFloat(Horizontal, horizontal);
        _animator.SetFloat(Vertical, vertical);
    }
}
