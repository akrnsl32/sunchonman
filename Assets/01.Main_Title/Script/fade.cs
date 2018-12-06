using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fade : MonoBehaviour {

    public UnityEngine.UI.Image fadeImage;
    public float fadeInTime = 1.0f;
    public float fadeOutTime = 1.0f;
    private float time = 1.0f;
    public enum fadeMode { fadein, fadeout };
    public fadeMode mode = fadeMode.fadein;
    public bool isFading = false;
    public static fade instance = null;

    private void OnLevelWasLoaded(int level)
    {
        SetFadeIn();
    }

    void Update()
    {
        if (!isFading) return;
        time -= Time.deltaTime;

        if (time > 0.0f)
        {
            if (mode == fadeMode.fadein)
                fadeImage.color = new Color(0, 0, 0, time * (1 / fadeInTime));
            else
                fadeImage.color = new Color(0, 0, 0, (1 - time) * (1 / fadeOutTime));
        }
        else if (time <= 0.0f)
        {
            isFading = false;
            if (mode == fadeMode.fadein)
                fadeImage.enabled = false;
        }
    }
    public void SetFadeIn()
    {
        time = fadeInTime;
        mode = fadeMode.fadein;
        fadeImage.enabled = true;
        isFading = true;
    }
    public void SetFadeOut()
    {
        time = fadeOutTime;
        mode = fadeMode.fadeout;
        fadeImage.enabled = true;
        isFading = true;
    }
}
