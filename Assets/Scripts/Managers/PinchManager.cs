using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PinchManager : MonoBehaviour
{
    [SerializeField] private Image Background;

    [SerializeField] private Sprite[] BackgroundSprites;

    private bool debounce = false;

    float dbTime = 0;

    private void Update()
    {
        if (debounce == true)
        {
            dbTime += Time.deltaTime;
            if (dbTime > 0.5f)
            {
                dbTime = 0;
                debounce = false;
            }
        }

        if (Input.touchSupported && Input.touchCount == 2 && !debounce)
        {
            Touch touch0 = Input.GetTouch(0);
            Touch touch1 = Input.GetTouch(1);

            Vector2 touch0Vector = touch0.position - touch0.deltaPosition;
            Vector2 touch1Vector = touch1.position - touch1.deltaPosition;

            float startMagnitude = (touch0.rawPosition - touch1.rawPosition).magnitude;

            TouchPhase touchPhase1 = touch0.phase;
            TouchPhase touchPhase2 = touch1.phase;

            float magnitude = (touch0Vector - touch1Vector).magnitude;

            float currentMagnitude = (touch0.position - touch1.position).magnitude;

            float magnitudeDifference = currentMagnitude - magnitude;

            if (magnitudeDifference < 0 && magnitude < 400)
            {
                SwitchBackground(Random.Range(0, BackgroundSprites.Length));
            }
        }
    }

    private void SwitchBackground(int index)
    {
        if (debounce == true)
        {
            return;
        }


        debounce = true;
        Background.sprite = BackgroundSprites[index];
    }
}
