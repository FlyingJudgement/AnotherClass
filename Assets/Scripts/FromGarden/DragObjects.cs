using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Collider))]

public class DragObjects : MonoBehaviour
{

    float ZPosition;
    Vector3 Offset;
    bool Dragging;

    public Camera mainCamera;
    [SerializeField]
    public UnityEvent OnBeginDrag;
    [SerializeField]
    public UnityEvent OnEndDrag;

    void Start()
    {
        mainCamera = Camera.main;
        ZPosition = mainCamera.WorldToScreenPoint(transform.position).z;
        //z axis of the game object
    }

    void Update()
    {
        if(Dragging) 
        {
            Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, ZPosition);
            transform.position = mainCamera.ScreenToWorldPoint(position + new Vector3(Offset.x, Offset.y));

        }
    }
    void OnMouseDown()
    {
        if(!Dragging)
        {
            BeginDrag();
        }
    }

    void OnMouseUp()
    {
        EndDrag();
    }

    public void BeginDrag()
    {
        OnBeginDrag.Invoke();
        Dragging = true;
        Offset = mainCamera.WorldToScreenPoint(transform.position) - Input.mousePosition;
    }

    public void EndDrag()
    {
        OnEndDrag.Invoke();
        Dragging = false;
    }
  
}
