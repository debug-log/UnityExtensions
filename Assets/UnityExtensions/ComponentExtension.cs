using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ComponentExtension {

    /// <summary>
    /// Copy the fields and properties of the target component.
    /// </summary>
    static public T CopyComponent<T> (this Component component) where T : Component
    {
        return component.gameObject.GetOrAddComponent<T> ();
    }

    /// <summary>
    /// Returns the component of type if the game object has one attached.
    /// If it hasn't component, Adds a component class of type type to the game object.
    /// </summary>
    static public T GetOrAddComponent<T> (this Component component) where T : Component
    {
        return component.gameObject.GetOrAddComponent<T> ();
    }

    /// <summary>
    /// Defensive GetComponent alternative. Component is required to print out an error message when it is not found.
    /// </summary>
    public static T GetSafeComponent<T> (this Component component) where T : Component
    {
        return component.GetSafeComponent<T> ();
    }
}
