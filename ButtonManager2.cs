using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManager2 : MonoBehaviour
{
    public Sprite spritePrefab1;
    public Sprite spritePrefab2;
    public Sprite spritePrefab3;
    public Sprite spritePrefab4;
    public Sprite spritePrefab5;
    public Sprite spritePrefab6;
    public Sprite spritePrefab7;
    public Sprite spritePrefab8;
    public Sprite spritePrefab9;
    public Sprite spritePrefab10;

    public Button button1;
    public Button button2;
    public Button button3;
    public Button button4;
    public Button button5;
    public Button button6;
    public Button button7;
    public Button button8;
    public Button button9;
    public Button button10;

    public Canvas canvas;

    void Start()
    {
        SetupButton(button1, spritePrefab1);
        SetupButton(button2, spritePrefab2);
        SetupButton(button3, spritePrefab3);
        SetupButton(button4, spritePrefab4);
        SetupButton(button5, spritePrefab5);
        SetupButton(button6, spritePrefab6);
        SetupButton(button7, spritePrefab7);
        SetupButton(button8, spritePrefab8);
        SetupButton(button9, spritePrefab9);
        SetupButton(button10, spritePrefab10);
    }

    void SetupButton(Button button, Sprite spritePrefab)
    {
        button.onClick.AddListener(() => OnButtonClick(button, spritePrefab));
    }

    void OnButtonClick(Button clickedButton, Sprite spritePrefab)
    {
        DisableAllButtonsExcept(clickedButton);

        GameObject newObject = new GameObject("NewObject");

        if (canvas != null)
        {
            newObject.transform.SetParent(canvas.transform, false);
        }
        else
        {
            Debug.LogError("Canvas is not assigned to the ButtonManager script!");
            return;
        }

        Image imageComponent = newObject.AddComponent<Image>();
        imageComponent.sprite = spritePrefab;
        newObject.layer = LayerMask.NameToLayer("UI");

        // ค้นหา GameObject ที่มีชื่อ "Ans2" ในฉาก
        GameObject ans1Object = GameObject.Find("Ans1");

        if (ans1Object != null)
        {
            // กำหนดตำแหน่งของวัตถุใหม่ให้เท่ากับตำแหน่งของ Ans2
            newObject.transform.position = ans1Object.transform.position;
            newObject.transform.localScale = new Vector3(0.5f, 0.5f);
        }
        else
        {
            Debug.LogError("GameObject with the name 'Ans1' not found in the scene!");
        }
    }

    void DisableAllButtonsExcept(Button activeButton)
    {
        Button[] allButtons = { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10 };

        foreach (Button button in allButtons)
        {
            button.interactable = (button == activeButton);
        }
    }
}
