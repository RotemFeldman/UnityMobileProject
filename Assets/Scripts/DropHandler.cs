using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using DG.Tweening;

public class DropHandler : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData eventData)
    {
        var droppedObj = eventData.pointerDrag;

        if (droppedObj.CompareTag("Option"))
        {
            droppedObj.transform.DOMove(transform.position, 0.5f, false);
        }
    }
}
