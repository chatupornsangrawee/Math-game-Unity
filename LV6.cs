using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LV6 : MonoBehaviour
{
    private List<int> availableScenes = new List<int>();
    public Button[] sceneButtons;

    void Start()
    {
        InitializeScenesList();
        InitializeButtons();
    }

    void InitializeScenesList()
    {
        for (int i = 1; i <= 50; i++)
        {
            availableScenes.Add(i);
        }
    }

    void InitializeButtons()
    {
        for (int i = 0; i < sceneButtons.Length; i++)
        {
            int buttonIndex = i + 1; // ปุ่มจะเริ่มต้นที่ 1
            sceneButtons[i].onClick.AddListener(() => LoadRandomScene(buttonIndex));
        }
    }

    public void LoadRandomScene(int buttonIndex)
    {
        if (availableScenes.Count > 0)
        {
            int randomIndex = Random.Range(0, availableScenes.Count);
            int sceneToLoad = availableScenes[randomIndex];
            availableScenes.RemoveAt(randomIndex);

            // ให้ใส่ชื่อฉากตรงนี้โดยตรง
            SceneManager.LoadScene(sceneToLoad.ToString());

            // ปิดปุ่มที่ถูกกด
            sceneButtons[buttonIndex - 1].interactable = false;
        }
        else
        {
            Debug.LogWarning("All scenes have been loaded!");
        }
    }
}