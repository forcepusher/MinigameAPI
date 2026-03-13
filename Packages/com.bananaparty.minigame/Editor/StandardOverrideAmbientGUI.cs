using UnityEditor;
using UnityEngine;

// Custom inspector for the StandardOverrideAmbient shader.
// Extends Unity's built-in StandardShaderGUI and adds an Ambient Color field.
public class StandardOverrideAmbientGUI : UnityEditor.StandardShaderGUI
{
    private MaterialProperty _ambientColor;

    public override void FindProperties(MaterialProperty[] props)
    {
        base.FindProperties(props);
        _ambientColor = FindProperty("_AmbientColor", props, false);
    }

    public override void OnGUI(MaterialEditor materialEditor, MaterialProperty[] props)
    {
        // Draw the default Standard shader UI.
        base.OnGUI(materialEditor, props);

        if (_ambientColor != null)
        {
            EditorGUILayout.Space();
            EditorGUILayout.LabelField("Ambient Override", EditorStyles.boldLabel);
            materialEditor.ColorProperty(_ambientColor, "Ambient Color");
        }
    }
}

