using Mirzipan.Bibliotheca.Identifiers;
using UnityEditor;
using UnityEngine;

namespace Mirzipan.Bibliotheca.Editor
{
    [CustomPropertyDrawer(typeof(QuadByte))]
    public class QuadByteDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            SerializedProperty value = property.FindPropertyRelative("Value");
            var text = new QuadByte((uint)value.intValue).ToString();
            value.intValue = (int)(uint)new QuadByte(EditorGUI.TextField(position, new GUIContent("4 Bytes"), text));
        }
    }
}