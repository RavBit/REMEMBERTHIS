using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppManager : MonoBehaviour
{
    public static AppManager instance;
    [Header("User information:")]
    public User User;

    // Makes sure the App_Manager does not get destroyed & Singleton 
    void Awake()
    {
        if (instance != null)
            Debug.LogError("More than one App Manager in the scene");
        else
            instance = this;
        DontDestroyOnLoad(transform.gameObject);
    }


    public void SetUser(User user)
    {
        User = user;
    }
}