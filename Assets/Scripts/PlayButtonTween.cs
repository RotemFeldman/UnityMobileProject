using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayButtonTween : MonoBehaviour
{
    private void Start()
    {
        if (gameObject != null)
        {
            transform.DOScale(1.5f, 1).SetLoops(-1, LoopType.Yoyo);
        }
    }
}
