using UnityEditor;
using UnityEngine;

public class CompileLock : MonoBehaviour
{
    [MenuItem("Compile/Lock", false)]
    static void Lock()
    {
        Debug.Log("�R���p�C�����o���Ȃ��Ȃ�܂���");
        EditorApplication.LockReloadAssemblies();
    }

    [MenuItem("Compile/Unlock", false)]
    static void Unlock()
    {
        Debug.Log("�R���p�C�����o����悤�ɂȂ�܂���");
        EditorApplication.UnlockReloadAssemblies();
    }
}
