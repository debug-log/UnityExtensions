using System;
using System.Reflection;
using UnityEngine;

public static class GameObjectExtension {

    /// <summary>
    /// Copy the fields and properties of the target component.
    /// </summary>
    public static Component CopyComponent<T> (this GameObject source, GameObject target) where T : Component
    {
        T original = target.GetComponent<T> ();
        if (original == null)
        {
            Debug.LogError (string.Format ("Expected to find component of type {0}, but not found.", typeof (T)), target);
            return null;
        }

        Type type = original.GetType ();
        Component copy = source.AddComponent (type);

        var fields = type.GetFields ();
        foreach (var field in fields)
        {
            field.SetValue (copy, field.GetValue (original));
        }

        var properties = type.GetProperties ();
        foreach (var property in properties)
        {
            bool isPropertyOfComponent = typeof (Component).IsAssignableFrom (property.PropertyType);
            bool isPropertyNameOrTag = property.Name.Equals ("name") || property.Name.Equals ("tag");
            
            if(isPropertyOfComponent || isPropertyNameOrTag)
            {
                continue;
            }

            try
            {
                property.SetValue (copy, property.GetValue (original, null), null);
            }
            catch { }
        }
        return copy;
    }

    /// <summary>
    /// Returns the component of type if the game object has one attached.
    /// If it hasn't component, Adds a component class of type type to the game object.
    /// </summary>
    static public T GetOrAddComponent<T> (this GameObject source) where T : Component
    {
        T result = source.GetComponent<T> ();
        if (result == null)
        {
            result = source.AddComponent<T> ();
        }
        return result;
    }

    /// <summary>
    /// Defensive GetComponent alternative. Component is required to print out an error message when it is not found.
    /// </summary>
    public static T GetSafeComponent<T> (this GameObject source) where T : Component
    {
        T component = source.GetComponent<T> ();

        if (component == null)
        {
            Debug.LogError (string.Format ("Expected to find component of type {0}, but not found.", typeof (T)), source);
        }

        return component;
    }
}
