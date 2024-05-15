using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragAndDropScript : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    private RectTransform rTransform;
    public Canvas canv;

    void Start()
    {
        rTransform = GetComponent<RectTransform>();
        
    }
    public void OnPointerDown(PointerEventData data)
    {
        Debug.Log("Clicked on the object!");
    }
    public void OnBeginDrag(PointerEventData data)
    {
        Debug.Log("Drag starts!");
    }

    public void OnDrag(PointerEventData data)
    {
        Vector2 mousePosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        mousePosition.x = Mathf.Clamp(mousePosition.x, 0 + rTransform.rect.width / 2, Screen.width - rTransform.rect.width / 2);
        mousePosition.y = Mathf.Clamp(mousePosition.y, 0 + rTransform.rect.height / 2, Screen.height - rTransform.rect.height / 2);

        rTransform.position = mousePosition;
        Debug.Log("x = "+mousePosition.x+"\n y = "+mousePosition.y);
    }

    public void OnEndDrag(PointerEventData data)
    {
        Debug.Log("Drag end!");
    }

}
