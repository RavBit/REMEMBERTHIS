using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowerManager : MonoBehaviour
{
    public GameObject Flower;
    // Use this for initialization
    void Awake()
    {
        int i = PlayerPrefs.GetInt("FlowerPlanting");
        if (i == 1)
        {
            Flower.SetActive(true);
        }
    }
    public void LoadMemory()
    {
        PlayerPrefs.GetInt("MemoryID");
        foreach(Memories M in MemoryManager.instance._memories)
        {
            if (M.ID == PlayerPrefs.GetInt("MemoryID"))
            {
                Debug.Log("Loading memory " + M.name);
            }
        }
    }
}

