using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayButtonTween : MonoBehaviour
{
    [SerializeField] private RectTransform[] _infoBars;

    private void Awake()
    {
        transform.DOScale(1.5f, 1).SetLoops(-1, LoopType.Yoyo);
    }
}
