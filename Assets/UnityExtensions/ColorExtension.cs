using UnityEngine;

public static class ColorExtension {

    /// <summary>
    /// Change alpha-component of this Color to value and Return.
    /// </summary>
    public static Color SetAlpha (this Color color, float a)
    {
        return new Color (color.r, color.g, color.b, a);
    }
}
