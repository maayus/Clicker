using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class Clicker : MonoBehaviour
{
    [Header("Animation settings")]

    public float scale = 1.2f;
    public float duration = 0.1f;
    public Ease ease;


    private int clicks = 0;

    private void OnMouseDown()
    {
        clicks++;
        GetComponent<AudioSource>().Play();
        UIManager.Instance.UpdateClicks(clicks);
        transform
            .DOScale(1, duration)
            .ChangeStartValue(scale * Vector3.one)
            .SetEase(ease);
            //.SetLoops(2, LoopType.Yoyo);
    }

    public void Update()
    {
        transform.Rotate(10 * Time.deltaTime, 10 * Time.deltaTime, 10 * Time.deltaTime);
    }
}
