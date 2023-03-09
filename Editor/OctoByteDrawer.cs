using Mirzipan.Bibliotheca.Identifiers;
using UnityEditor;
using UnityEngine;

namespace Mirzipan.Bibliotheca.Editor
{
    [CustomPropertyDrawer(typeof(OctoByte))]
    public class OctoByteDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            SerializedProperty value = property.FindPropertyRelative("Value");
            var text = new OctoByte((ulong)value.longValue).ToString();
            value.longValue = (long)(ulong)new OctoByte(EditorGUI.TextField(position, label, text));
        }
    }
}