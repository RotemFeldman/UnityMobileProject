using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDrop : MonoBehaviour
{
    [SerializeField] private RectTransform _image;

    private float Vertical;
    private float Horizontal;

    public void AlignWithPointer()
    {
        _image.anchoredPosition = new Vector2(Input.mousePosition.x - Screen.width/2, Input.mousePosition.y - Screen.width/2);
    }
}
