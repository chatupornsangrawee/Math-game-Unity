using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnObjectOnObjectClick : MonoBehaviour
{
    public GameObject objectToSpawn; // UI Element ที่ต้องการสร้างขึ้นมา
    public GameObject selectedObject; // วัตถุที่ถูกคลิก
    public RectTransform spawnPosition; // ตำแหน่งที่จะวาง UI ที่ถูกสร้างขึ้น

    void Update()
    {
        // ตรวจสอบการคลิก
        if (Input.GetMouseButtonDown(0))
        {
            // ดึงตำแหน่งที่คลิก
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePosition2D = new Vector2(mousePosition.x, mousePosition.y);

            // ตรวจสอบว่าคลิกอยู่ในขอบเขตของวัตถุหรือไม่
            Collider2D hitCollider = Physics2D.OverlapPoint(mousePosition2D);
            if (hitCollider != null && hitCollider.gameObject == selectedObject)
            {
                // สร้าง UI ใหม่
                GameObject newUI = Instantiate(objectToSpawn, spawnPosition);

                // ตำแหน่งของ UI ใหม่เป็นตำแหน่งของ spawnPosition
                newUI.GetComponent<RectTransform>().anchoredPosition = Vector2.zero; // ให้ตำแหน่ง UI ใหม่อยู่ที่ (0, 0)

                // Debug
                Debug.Log("UI Created");
            }
            else
            {
                // Debug
                Debug.Log("No object selected or not clicking on the selected object");
            }
        }
    }

    // เมื่อคลิกที่วัตถุ
    void OnMouseDown()
    {
        selectedObject = gameObject;
        
        // Debug
        Debug.Log("Object Selected");
    }

    void Start()
    {
        // กำหนดให้ spawnPosition เป็น RectTransform ที่มีตำแหน่งที่ต้องการ
        // โปรดตรวจสอบให้แน่ใจว่าคุณต้องการให้ค่าในตัวแปรนี้ที่ถูกกำหนดใน Inspector
        // หรือตรวจสอบว่า RectTransform ที่คุณต้องการอยู่ในฉบับที่ใช้งานแล้ว
        
        // Debug
        Debug.Log("Spawn Position Set");
    }
}
