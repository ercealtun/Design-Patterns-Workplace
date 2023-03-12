using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton : MonoBehaviour
{
    // VARIABLES

    private static Singleton instance = null;
    private String text;
    
    
    // METHODS

    private Singleton() {}
    
    // Static Feature
    public static Singleton Instance
    {
        get
        {
            /* If instance is null, the FindObjectOfType function
             finds this existing script object in the scene and assigns 
             it to the instance variable.
            */ 
            if (instance == null)
            {
                instance = FindObjectOfType<Singleton>();

                if (instance == null) // If its still null, then create a new game object with singleton component
                {
                    instance = new GameObject("Singleton").AddComponent<Singleton>();
                } 
            }
            
            return instance;
        }
    }
    
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(this);
        }
        DontDestroyOnLoad(this);
    }

    private void OnEnable()
    {
        instance = this;
        text = "Hello World!";
    }

    public string GetText()
    {
        return text;
    }
    
}
