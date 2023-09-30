using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using DG.Tweening;

public class DropHandler : MonoBehaviour, IDropHandler
{

    public GameObject TurnOverButton;

    public int PlayerNumber;

    private string PlayerChoice;

    private void Update()
    {
        if (TurnOverButton != null)
        {
            if (transform.childCount > 0)
            {
                TurnOverButton.SetActive(true);
            }
            else
            {
                TurnOverButton.SetActive(false);
            }
        }
    }

    public void OnDrop(PointerEventData eventData)
    {
        /*if (GamePause.IsPaused)
            return;

        var droppedObj = eventData.pointerDrag;

        if (droppedObj.CompareTag("Option"))
        {
            droppedObj.transform.DOMove(transform.position, 0.5f, false);
        }*/

        if (transform.childCount > 0)
        {
            DragAndDrop dd = GetComponentInChildren<DragAndDrop>();

            if (dd.transform.parent == dd.OriginalSlot)
                return;
            else
                dd.ReturnToOriginalParent();            
        }


        GameObject droppedObj = eventData.pointerDrag;
        DragAndDrop dragAndDrop = droppedObj.GetComponent<DragAndDrop>();
        dragAndDrop.setParentAfterDrag = transform;

        PlayerChoice = droppedObj.tag;


        GameRunner.instance.PlayerChoice(PlayerNumber, PlayerChoice);

    }
}
