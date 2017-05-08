/*
 * Author:      ����
 * CreateTime:  12/26/2016 4:54:18 PM
 * Description:
 * 
*/
using UnityEditor;
using UnityEngine;

namespace EZFramework
{
    [CustomEditor(typeof(WWWTask))]
    public class WWWTaskEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();
            WWWTask task = target as WWWTask;
            EditorGUILayout.LabelField("URL", task.url);
            EditorGUILayout.Slider("progress", task.www.progress, 0, 1);
            if (GUI.changed) EditorUtility.SetDirty(task);
        }
    }

    [CustomEditor(typeof(EZSound))]
    public class EZSoundEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            EZSound ezSound = target as EZSound;
            ezSound.SpatialBlend = EditorGUILayout.Slider("Global Spatial Blend", ezSound.SpatialBlend, 0, 1);

            ezSound.BgmActive = EditorGUILayout.Toggle("BGM", ezSound.BgmActive);
            if (ezSound.BgmActive)
                ezSound.BgmVolume = EditorGUILayout.Slider(ezSound.BgmVolume, 0, 1);

            ezSound.EfxActive = EditorGUILayout.Toggle("EFX", ezSound.EfxActive);
            if (ezSound.EfxActive)
                ezSound.EfxVolume = EditorGUILayout.Slider(ezSound.EfxVolume, 0, 1);

            if (GUI.changed) EditorUtility.SetDirty(ezSound);
        }
    }
}