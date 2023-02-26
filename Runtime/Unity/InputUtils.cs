using UnityEngine;

namespace Mirzipan.Bibliotheca.Unity
{
    public static class InputUtils
    {
        /*
         * Key states:
         * Up - is not pressed
         * Pressed - key was pressed right now
         * Down - key was pressed and is still being pressed
         * Released - key was released right now
         */
        
        public static bool IsAltPressed => Input.GetKeyDown(KeyCode.LeftAlt) || Input.GetKeyDown(KeyCode.RightAlt);
        public static bool IsCtrlPressed => Input.GetKeyDown(KeyCode.LeftControl) || Input.GetKeyDown(KeyCode.RightControl);
        public static bool IsShiftPressed => Input.GetKeyDown(KeyCode.LeftShift) || Input.GetKeyDown(KeyCode.RightShift);
        public static bool IsMetaPressed => Input.GetKeyDown(KeyCode.LeftMeta) || Input.GetKeyDown(KeyCode.RightMeta);
        public static bool IsModifierPressed => IsAltPressed || IsCtrlPressed || IsShiftPressed || IsMetaPressed;

        public static bool IsAltDown => Input.GetKey(KeyCode.LeftAlt) || Input.GetKey(KeyCode.RightAlt);
        public static bool IsCtrlDown => Input.GetKey(KeyCode.LeftControl) || Input.GetKey(KeyCode.RightControl);
        public static bool IsShiftDown => Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift);
        public static bool IsMetaDown => Input.GetKey(KeyCode.LeftMeta) || Input.GetKey(KeyCode.RightMeta);
        public static bool IsModifierDown => IsAltDown || IsCtrlDown || IsShiftDown || IsMetaDown;
        
        public static bool IsAltReleased => Input.GetKeyUp(KeyCode.LeftAlt) || Input.GetKeyUp(KeyCode.RightAlt);
        public static bool IsCtrlReleased => Input.GetKeyUp(KeyCode.LeftControl) || Input.GetKeyUp(KeyCode.RightControl);
        public static bool IsShiftReleased => Input.GetKeyUp(KeyCode.LeftShift) || Input.GetKeyUp(KeyCode.RightShift);
        public static bool IsMetaReleased => Input.GetKeyUp(KeyCode.LeftMeta) || Input.GetKeyUp(KeyCode.RightMeta);
        public static bool IsModifierReleased => IsAltReleased || IsCtrlReleased || IsShiftReleased || IsMetaReleased;
    }
}