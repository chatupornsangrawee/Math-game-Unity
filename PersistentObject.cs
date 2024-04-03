using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersistentObject : MonoBehaviour
{
    private static PersistentObject instance;

    private void Awake()
    {
        if (instance == null)
        {
            // ถ้ายังไม่มี instance ให้ทำ PersistentObject เป็น Singleton
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            // ถ้ามี instance แล้วให้ทำลายตัวเอง
            Destroy(gameObject);
        }
    }

    // ฟังก์ชันอื่นๆที่คุณต้องการจะทำให้ PersistentObject ทำได้
}