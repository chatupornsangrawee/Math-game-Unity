using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SceneRandomizer : MonoBehaviour
{
    public Button randomSceneButton;
    public int totalScenes = 50;

    private void Start()
    {
        // ตรวจสอบว่าปุ่มถูกกำหนดให้ใน Inspector
        if (randomSceneButton != null)
        {
            // เพิ่มฟังก์ชั่นเมื่อปุ่มถูกคลิก
            randomSceneButton.onClick.AddListener(RandomizeScene);
        }
    }

    void RandomizeScene()
    {
        // สุ่มหมายเลขฉาก
        int randomSceneIndex = Random.Range(1, totalScenes + 1);

        // สลับฉาก
        StartCoroutine(LoadSceneAsync(randomSceneIndex.ToString()));
    }

    IEnumerator LoadSceneAsync(string sceneName)
    {
        // โค้ดเพื่อโหลดฉากแบบ asynchronous
        AsyncOperation asyncLoad = UnityEngine.SceneManagement.SceneManager.LoadSceneAsync(sceneName);

        // รอให้ฉากโหลดเสร็จ
        while (!asyncLoad.isDone)
        {
            yield return null;
        }
    }
}
