using UnityEditor;
using UnityEngine;

public class CompileLock : MonoBehaviour
{
    [MenuItem("Compile/Lock", false)]
    static void Lock()
    {
        Debug.Log("コンパイルが出来なくなりました");
        EditorApplication.LockReloadAssemblies();
    }

    [MenuItem("Compile/Unlock", false)]
    static void Unlock()
    {
        Debug.Log("コンパイルが出来るようになりました");
        EditorApplication.UnlockReloadAssemblies();
    }
}
