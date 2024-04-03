using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonClickHandler : MonoBehaviour
{
    // กำหนดชื่อฉากที่ต้องการโหลดต่อไป
    public string nextSceneName;

    // เมธอดนี้จะถูกเรียกเมื่อปุ่มถูกคลิก
    public void OnButtonClick()
    {
        // โหลดฉากต่อไป
        SceneManager.LoadScene(nextSceneName);
    }
}
