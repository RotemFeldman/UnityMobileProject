using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using DG.Tweening;
using UnityEngine.UI;

public class DragAndDrop : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    /*    [SerializeField] private RectTransform _image;
        [SerializeField] private GameObject _gridParent;

        private bool _canDrag = true;

        private float Vertical;
        private float Horizontal;

        public void OnBeginDrag(PointerEventData eventData)
        {
            if (GamePause.IsPaused)
                return;
        }

        public void OnDrag(PointerEventData eventData)
        {
            if (GamePause.IsPaused)
                return;
            if (_canDrag)
            {
                if (eventData.pointerDrag.transform.parent.name == "Grid")
                {
                    eventData.pointerDrag.transform.SetParent(_gridParent.transform.parent);
                }

                //AlignWithPointer();
            }

            transform.position = eventData.position;
        }

        public void OnEndDrag(PointerEventData eventData)
        {
            if (GamePause.IsPaused)
                return;
        }*/




    public Image image;
    public Transform OriginalSlot;
    [HideInInspector]  public Transform setParentAfterDrag;

    public void OnBeginDrag(PointerEventData eventData)
    {
        // rememeber what the object is hovering above
        setParentAfterDrag = transform.parent;

        image.raycastTarget = false;

        // set as top of hirerchy for while dragging
        transform.SetParent(transform.root);
        transform.SetAsLastSibling();
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = eventData.position;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        transform.SetParent(setParentAfterDrag);
        image.raycastTarget = true;
    }

    public void ReturnToOriginalParent()
    {
        transform.SetParent(OriginalSlot);
    }

    private void OnValidate()
    {
        if (image == null)
        {
            image = this.GetComponent<Image>();
        }

        if (OriginalSlot == null)
        {
            OriginalSlot = transform.parent;
        }
    }
}
