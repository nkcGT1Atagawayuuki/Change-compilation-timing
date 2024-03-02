#if UNITY_EDITOR

using UnityEngine;
using UnityEditor;

public class CompileConfig
{
    [InitializeOnLoadMethod]
    public static void Initialize()
    {
        EditorApplication.playModeStateChanged += (PlayModeStateChange currentState) =>
        {
            LockReload(currentState);
            UnlockReload(currentState);
        };
    }


    /// <summary>
    /// エディターモードの時はコンパイルを出来ないようにする
    /// </summary>
    /// <param name="currentState"></param>
    public static void LockReload(PlayModeStateChange currentState)
    {
        if (currentState == PlayModeStateChange.EnteredEditMode)
        {
            //Debug.Log("コンパイルが出来なくなりました");
            EditorApplication.LockReloadAssemblies();
        }
    }

    /// <summary>
    /// プレイモードの時はコンパイル出来るようにする
    /// </summary>
    /// <param name="currentState"></param>
    public static void UnlockReload(PlayModeStateChange currentState)
    {
        if(currentState == PlayModeStateChange.ExitingEditMode)
        {
            //Debug.Log("コンパイルが出来るようになりました");
            EditorApplication.UnlockReloadAssemblies();
        }
    }
}

#endif