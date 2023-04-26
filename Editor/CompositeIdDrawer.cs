using Mirzipan.Bibliotheca.Identifiers;
using UnityEditor;
using UnityEngine;

namespace Mirzipan.Bibliotheca.Editor
{
    [CustomPropertyDrawer(typeof(CompositeId))]
    public class CompositeIdDrawer : PropertyDrawer
    {
        private const float SubLabelSpacing = 4;
        
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            label = EditorGUI.BeginProperty(position, label, property);
            position = EditorGUI.PrefixLabel(position, GUIUtility.GetControlID(FocusType.Passive), label);

            SerializedProperty value = property.FindPropertyRelative("Value");
            var composite = new CompositeId((ulong)value.longValue);
            var q1 = composite.Primary;
            var q2 = composite.Secondary;
            
            // backup gui settings
            int indent = EditorGUI.indentLevel;
            float labelWidth = EditorGUIUtility.labelWidth;
            
            float width = (position.width - SubLabelSpacing) / 2;
            position = new Rect(position.x, position.y, width, position.height);

            var q1Content = new GUIContent("P");
            var q2Content = new GUIContent("S");
            
            EditorGUI.indentLevel = 0;
            EditorGUIUtility.labelWidth = EditorStyles.label.CalcSize(q1Content).x;
            q1 = new QuadByte(EditorGUI.TextField(position, q1Content, q1.ToString()));
            position.x += width + SubLabelSpacing;
            q2 = new QuadByte(EditorGUI.TextField(position, q2Content, q2.ToString()));
            value.longValue = (long)new CompositeId(q1, q2).Value;
            
            // restore gui settings
            EditorGUIUtility.labelWidth = labelWidth;
            EditorGUI.indentLevel = indent;
            
            EditorGUI.EndProperty();
        }
    }
}