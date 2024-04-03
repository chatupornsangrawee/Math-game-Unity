using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Button button1;
    public Button button2;
    public Button button3;

    public GameObject successPanel;
    public GameObject failurePanelText;
    public GameObject failurePanelText2;
    

    private bool button1Pressed = false;
    private bool button2Pressed = false;
    private bool buttonsConfirmed = false;

    void Start()
    {
        button1.onClick.AddListener(CheckButton1Pressed);
        button2.onClick.AddListener(CheckButton2Pressed);
        button3.onClick.AddListener(CheckButton3Pressed);
    }

    void CheckButton1Pressed()
    {
        button1Pressed = true;
    }

    void CheckButton2Pressed()
    {
        button2Pressed = true;
    }

    void CheckButton3Pressed()
    {
        if (button1Pressed && button2Pressed)
        {
            buttonsConfirmed = true;
        }

        if (buttonsConfirmed)
        {
            // โหลด panel สำหรับการกดถูกต้อง (ที่มีรูป)
            successPanel.SetActive(true);
        }
        else
        {
            // โหลด panel สำหรับการกดผิด (ที่มีข้อความ)
            failurePanelText.SetActive(true);
            failurePanelText2.SetActive(true);
        }
    }
}