using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;
using UnityEngine.UIElements;


public class UITween : MonoBehaviour
{
    [SerializeField] private RectTransform[] _infoBars;

    private void Start()
    {
        foreach (RectTransform obj in _infoBars)
        {
            obj.DOAnchorPos(new Vector2(-200, obj.anchoredPosition.y), 1, false).SetLoops(-1, LoopType.Yoyo);
        }
    }
}
