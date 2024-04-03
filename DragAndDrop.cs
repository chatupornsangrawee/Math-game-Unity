using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using UnityEngine.SceneManagement;

public class DragAndDrop : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    private RectTransform rectTransform;
    private CanvasGroup canvasGroup;

    public Transform dropZone; // นำไปวางที่นี่
    private Image dropZoneImage;

    private bool dropped = false;

    private void Start()
    {
        rectTransform = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
        if (canvasGroup == null)
        {
            // ถ้า CanvasGroup ยังไม่มี, เพิ่ม CanvasGroup
            canvasGroup = gameObject.AddComponent<CanvasGroup>();
        }
        dropZoneImage = dropZone.GetComponent<Image>();
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        // จัดเตรียมการลาก
        canvasGroup.alpha = 0.6f;

        // อนุญาตให้ลากเฉพาะเมื่ออยู่ใน dropZone
        if (IsInDropZone())
        {
            canvasGroup.blocksRaycasts = !dropped;
        }
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        // เริ่มลาก
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        // จบการลาก
        canvasGroup.alpha = 1f;
        canvasGroup.blocksRaycasts = true;

        // ตรวจสอบว่าวางลงใน drop zone หรือไม่
        if (IsInDropZone())
        {
            // ถ้าวางลงใน drop zone ให้เปลี่ยนรูปภาพใน drop zone ตามรูปที่ถูกลากมา
            dropZoneImage.sprite = GetComponent<Image>().sprite;
            dropped = true; // ทำเครื่องหมายว่าได้วางลงแล้ว

            // เริ่ม Coroutine เพื่อทำลายวัตถุที่ถูกลากหลังจากผ่านไป 0.001 วินาที
            StartCoroutine(DestroyAfterDelay(0.001f));
        }
    }

    public void OnDrag(PointerEventData eventData)
    {
        // กำหนดตำแหน่งของ rectTransform ตามตำแหน่งของเมาส์
        rectTransform.anchoredPosition += eventData.delta / GetComponentInParent<Canvas>().scaleFactor;
    }

    // Coroutine สำหรับทำลายวัตถุหลังจากผ่านไปเวลาที่กำหนด
    private IEnumerator DestroyAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);

        // ทำลายวัตถุ
        Destroy(gameObject);

    }

    // เช็คว่าอยู่ใน dropZone หรือไม่
    private bool IsInDropZone()
    {
        return RectTransformUtility.RectangleContainsScreenPoint(dropZoneImage.rectTransform, Input.mousePosition);
    }
}
