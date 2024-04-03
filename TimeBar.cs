using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeBar : MonoBehaviour
{
    public Transform filbar;
    public float currentTime; // ตัวแสดงค่าเวลา
    public float delay; // ไม่ต้องกำหนดค่า delay ที่นี้
    public static TimeBar instance;

    void Start()
    {
        currentTime = 1;
        delay = 1f / 15f; // ปรับ delay เพื่อให้นับถอยหลังเป็น 15 วินาที
    }

    private void Awake()
    {
        MakeInstance();
    }

    void MakeInstance()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= delay * Time.deltaTime;
        filbar.GetComponent<Image>().fillAmount = currentTime;

        if (currentTime <= 0)
        {
            // โหลดฉากปัจจุบันขึ้นมาใหม่ (ให้แทน "YourSceneName" ด้วยชื่อฉากที่ต้องการ)
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
