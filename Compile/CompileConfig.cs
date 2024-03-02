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
    /// �G�f�B�^�[���[�h�̎��̓R���p�C�����o���Ȃ��悤�ɂ���
    /// </summary>
    /// <param name="currentState"></param>
    public static void LockReload(PlayModeStateChange currentState)
    {
        if (currentState == PlayModeStateChange.EnteredEditMode)
        {
            //Debug.Log("�R���p�C�����o���Ȃ��Ȃ�܂���");
            EditorApplication.LockReloadAssemblies();
        }
    }

    /// <summary>
    /// �v���C���[�h�̎��̓R���p�C���o����悤�ɂ���
    /// </summary>
    /// <param name="currentState"></param>
    public static void UnlockReload(PlayModeStateChange currentState)
    {
        if(currentState == PlayModeStateChange.ExitingEditMode)
        {
            //Debug.Log("�R���p�C�����o����悤�ɂȂ�܂���");
            EditorApplication.UnlockReloadAssemblies();
        }
    }
}

#endif