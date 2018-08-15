using UnityEngine;

public static class VectorExtension {

    /// <summary>
    /// Returns only the xy-component of this vector.
    /// </summary>
    public static Vector2 ToXY (this Vector3 v)
    {
        return new Vector2 (v.x, v.y);
    }

    /// <summary>
    /// Returns only the yz-component of this vector.
    /// </summary>
    public static Vector2 ToYZ (this Vector3 v)
    {
        return new Vector2 (v.y, v.z);
    }

    /// <summary>
    /// Returns only the xz-component of this vector.
    /// </summary>
    public static Vector2 ToXZ (this Vector3 v)
    {
        return new Vector2 (v.x, v.z);
    }


    /// <summary>
    /// Change x-component of this vector to value and Return.
    /// </summary>
    public static Vector3 SetX(this Vector3 v, float value)
    {
        return new Vector3 (value, v.y, v.z);
    }

    /// <summary>
    /// Change y-component of this vector to value and Return.
    /// </summary>
    public static Vector3 SetY (this Vector3 v, float value)
    {
        return new Vector3 (v.x, value, v.z);
    }

    /// <summary>
    /// Change z-component of this vector to value and Return.
    /// </summary>
    public static Vector3 SetZ (this Vector3 v, float value)
    {
        return new Vector3 (v.x, v.y, value);
    }

    /// <summary>
    /// Returns opposite only x-component of this vector
    /// </summary>
    public static Vector3 OppositeX (this Vector3 v)
    {
        return new Vector3 (-v.x, v.y, v.z);
    }

    /// <summary>
    /// Returns opposite only y-component of this vector
    /// </summary>
    public static Vector3 OppositeY (this Vector3 v)
    {
        return new Vector3 (v.x, -v.y, v.z);
    }

    /// <summary>
    /// Returns opposite only z-component of this vector
    /// </summary>
    public static Vector3 OppositeZ (this Vector3 v)
    {
        return new Vector3 (v.x, v.y, -v.z);
    }

}
