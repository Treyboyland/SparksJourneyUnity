using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(BoxColliderFixer))]
[CanEditMultipleObjects]
public class BoxColliderFixerEditor : Editor
{
    public override void OnInspectorGUI()
    {
        if (GUILayout.Button("Fix collider"))
        {
            foreach (var obj in serializedObject.targetObjects)
            {
                Debug.Log(obj.name);
                var fixer = obj as BoxColliderFixer;
                if (fixer)
                {
                    fixer.FixCollider();
                }
            }
            serializedObject.ApplyModifiedProperties();
        }
    }
}
