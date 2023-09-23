using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using DG.Tweening;

public class DragAndDrop : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    [SerializeField] private RectTransform _image;
    [SerializeField] private GameObject _gridParent;

    private bool _canDrag = true;

    private float Vertical;
    private float Horizontal;

    public void OnBeginDrag(PointerEventData eventData)
    {

    }

    public void OnDrag(PointerEventData eventData)
    {
        if (_canDrag)
        {
            if (eventData.pointerDrag.transform.parent.name == "Circles")
            {
                eventData.pointerDrag.transform.SetParent(_gridParent.transform.parent);
            }

            //AlignWithPointer();
        }

        transform.position = eventData.position;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
       
    }
}
