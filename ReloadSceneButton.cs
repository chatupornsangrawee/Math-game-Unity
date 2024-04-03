using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ReloadSceneButton : MonoBehaviour
{
    // ให้แอ็ตทริบิวต์นี้กับปุ่มใน Inspector
    public void ReloadCurrentScene()
    {
        // โหลดฉากปัจจุบันใหม่
        Scene currentScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(currentScene.name);
    }
}
