using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class SpriteRendererExtension {

    public static void SetAlpha (this SpriteRenderer sr, float a)
    {
        sr.color = sr.color.SetAlpha (a);
    }
}
