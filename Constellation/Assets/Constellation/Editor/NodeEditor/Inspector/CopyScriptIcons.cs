using Constellation;
using UnityEditor;
using UnityEngine;

// makes sure that the static constructor is always called in the editor.
namespace ConstellationEditor
{
    [InitializeOnLoad]
    public class CopyScriptIcons : Editor
    {
        private static bool isDraggable;
        static CopyScriptIcons()
        {
            var source = (Texture2D)AssetDatabase.LoadAssetAtPath(ConstellationEditor.GetEditorAssetPath() + "ConstellationScript.png", typeof(Texture2D));
            var target = (Texture2D)AssetDatabase.LoadAssetAtPath("Assets/Gizmos/ConstellationScript Icon.png", typeof(Texture2D));
            if (source != null && target == null)
                AssetDatabase.CopyAsset(ConstellationEditor.GetEditorAssetPath() + "ConstellationScript.png", "Assets/Gizmos/ConstellationScript Icon.png");
        }
    }
}