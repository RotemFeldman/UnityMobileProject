using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButtonTween : MonoBehaviour
{
    private void Start()
    {
        if (SceneManager.GetActiveScene().buildIndex == 1)
        {
            transform.DOScale(1.5f, 1).SetLoops(-1, LoopType.Yoyo);
        }
    }
}
