using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(Hover))]
public class OscillateYEditor : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        Hover script = (Hover)target;

        if (GUILayout.Button("Reset Start Position"))
        {
            script.ResetStartPosition();

            // Mark object as dirty so Unity saves the change
            EditorUtility.SetDirty(script);
        }
    }
}