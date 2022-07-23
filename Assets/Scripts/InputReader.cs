using UnityEngine;

public class InputReader : MonoBehaviour
{
    [SerializeField] private PlayerInput _playerInput;
    
    private void Update()
    {
        _playerInput.Clear();
        var horizontal = Input.GetAxisRaw("Horizontal");
        var vertical = Input.GetAxisRaw("Vertical");
        DebugGui.Instance.PrintLine($"horizontal: {horizontal} vertical: {vertical}");
        if (vertical > 0)
        {
            _playerInput.Forward = true;
        }
        if (vertical < 0)
        {
            _playerInput.Backward = true;
        }
        if (horizontal > 0)
        {
            _playerInput.Right = true;
        }
        if (horizontal < 0)
        {
            _playerInput.Left = true;
        }
    }
}