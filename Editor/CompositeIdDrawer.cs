using Mirzipan.Bibliotheca.Identifiers;
using UnityEditor;
using UnityEngine;

namespace Mirzipan.Bibliotheca.Editor
{
    [CustomPropertyDrawer(typeof(CompositeId))]
    public class CompositeIdDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            SerializedProperty value = property.FindPropertyRelative("Value").FindPropertyRelative("Value");
            var composite = new CompositeId(new OctoByte((ulong)value.longValue));
            var q1 = composite.Primary;
            var q2 = composite.Secondary;

            var rect = EditorGUI.PrefixLabel(position, label);
            float halfW = rect.width * .5f;
            rect.width = halfW;
            q1 = new QuadByte(EditorGUI.TextField(rect, q1.ToString()));
            rect.x += halfW;
            q2 = new QuadByte(EditorGUI.TextField(rect, q2.ToString()));
            value.longValue = (long)(ulong)new CompositeId(q1, q2);
        }
    }
}