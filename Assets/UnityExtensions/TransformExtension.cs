using UnityEngine;

public static class TransformExtension {

    /// <summary>
    /// Set the x-position of this transform.
    /// </summary>
    public static void SetPositionX (this Transform transform, float x)
    {
        Vector3 position = transform.position;
        position.x = x;
        transform.position = position;
    }

    /// <summary>
    /// Set the y-position of this transform.
    /// </summary>
    public static void SetPositionY (this Transform transform, float y)
    {
        Vector3 position = transform.position;
        position.y = y;
        transform.position = position;
    }

    /// <summary>
    /// Set the z-position of this transform.
    /// </summary>
    public static void SetPositionZ (this Transform transform, float z)
    {
        Vector3 position = transform.position;
        position.z = z;
        transform.position = position;
    }

    /// <summary>
    /// Moves in the x-direction from the current position.
    /// </summary>
    public static void TranslateX (this Transform transform, float x)
    {
        Vector3 position = transform.position;
        position.x += x;
        transform.position = position;
    }

    /// <summary>
    /// Moves in the y-direction from the current position.
    /// </summary>
    public static void TranslateY (this Transform transform, float y)
    {
        Vector3 position = transform.position;
        position.y += y;
        transform.position = position;
    }

    /// <summary>
    /// Moves in the z-direction from the current position.
    /// </summary>
    public static void TranslateZ (this Transform transform, float z)
    {
        Vector3 position = transform.position;
        position.z += z;
        transform.position = position;
    }

    /// <summary>
    /// Invert x-position of this transform.
    /// </summary>
    public static void InvertPositionX (this Transform transform)
    {
        transform.position = transform.position.OppositeX();
    }

    /// <summary>
    /// Invert y-position of this transform.
    /// </summary>
    public static void InvertPositionY (this Transform transform)
    {
        transform.position = transform.position.OppositeY ();
    }

    /// <summary>
    /// Invert z-position of this transform.
    /// </summary>
    public static void InvertPositionZ (this Transform transform)
    {
        transform.position = transform.position.OppositeZ ();
    }
}
