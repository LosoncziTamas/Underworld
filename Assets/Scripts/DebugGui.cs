using System.Text;
using UnityEngine;

public class DebugGui : MonoBehaviour
{
    public StringBuilder StringBuilder { get; } = new();

    public static DebugGui Instance;
    
    private readonly GUIStyle _guiStyle = GUIStyle.none;
    private Rect _windowRect = new(20, 20, 400, 300);
    private void Awake()
    {
        _guiStyle.fontSize = 30;
        _guiStyle.normal.textColor = Color.white;
        Instance = this;
    }

    public void PrintLine(string line)
    {
        if (StringBuilder.Length > 0)
        {
            StringBuilder.Clear();
        }
        StringBuilder.Append(line).Append("\n");
    }

    private void OnGUI()
    {
        _windowRect = GUILayout.Window(0, _windowRect, RenderDebugWindow, "Debug GUI");
    }

    private void RenderDebugWindow(int id)
    {
        GUILayout.Label(StringBuilder.ToString(), _guiStyle);
    }
}