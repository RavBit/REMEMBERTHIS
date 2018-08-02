using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ContentManager : MonoBehaviour {
    public Sprite[] Thumbnails;
    public AudioClip[] Sounds;
    public static ContentManager instance;


    // Makes sure the ContentManager does not get destroyed & Singleton 
    void Awake()
    {
        if (instance != null)
            Debug.LogError("More than one Content Manager in the scene");
        else
            instance = this;
        DontDestroyOnLoad(transform.gameObject);
    }
}
