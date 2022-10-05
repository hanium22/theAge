using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Drag : MonoBehaviour, IDragHandler

{

    private Vector3 screenSpace;

    private Vector3 offset;

    public void OnMouseDown()

    {

        Debug.Log("오브젝트 터치");

        //translate the cubes position from the world to Screen Point

        screenSpace = Camera.main.WorldToScreenPoint(transform.position);

        //calculate any difference between the cubes world position and the mouses Screen position converted to a world point 

        offset = transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenSpace.z));

    }

    float distance = 10.0f;
    public void OnDrag(PointerEventData eventData)
    {
        Vector3 mousePosition = new Vector3(Input.mousePosition.x,
 Input.mousePosition.y, distance);
        transform.position = mousePosition;
    }
    public void OnMouseUp()

    {

        Debug.Log("오브젝트에서 손 뗌");

    }

}