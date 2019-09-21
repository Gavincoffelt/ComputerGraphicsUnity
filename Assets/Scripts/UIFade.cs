﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIFade : MonoBehaviour
{
    //Main Canvas
    public CanvasGroup canvas;
// Fades Canvas into the scene.
    public void FadeIn()
    {
        StartCoroutine(CanvasFade(canvas, canvas.alpha, 1));
    }
    // Fades Canvas out of the scene.
    public void FadeOut()
    {
        StartCoroutine(CanvasFade(canvas, canvas.alpha, 0));
    }
    // The IEnumerator Controlling FadeIn/FadeOut. Lerps the alpha of the CanvasGroup to switch in between appearing on screen and not.
    public IEnumerator CanvasFade(CanvasGroup cg, float start, float end, float lerpTime = 0.5f)
    {
        float startOfLerp = Time.time;
        float timeSinceStart = Time.time - startOfLerp;
        float percentageDone = timeSinceStart / lerpTime;
        while(true)
        {
            timeSinceStart = Time.time - startOfLerp;
            percentageDone = timeSinceStart / lerpTime;

            float currentValue = Mathf.Lerp(start, end, percentageDone);

            cg.alpha = currentValue;
            if (percentageDone >= 1) break;

            yield return new WaitForEndOfFrame();
        }

    }
    // Update function to utilize the Esc key to switch the menu on and off.
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && canvas.alpha.Equals(0))
        {
            FadeIn();
            Debug.Log("FadeIn");
        }
        if (Input.GetKeyDown(KeyCode.Escape) && canvas.alpha.Equals(1))
        {
            FadeOut();
            Debug.Log("FadeOut");
        }

    }
}
