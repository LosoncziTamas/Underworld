using UnityEngine;

[CreateAssetMenu]
public class PlayerInput : ScriptableObject
{
    public bool Left { get; set; }
    public bool Right { get; set; }
    public bool Forward { get; set; }
    public bool Backward { get; set; }

    public void Clear()
    {
        Left = Right = Forward = Backward = false;
    }
}