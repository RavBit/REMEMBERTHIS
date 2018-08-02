using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class UIManager : MonoBehaviour {
    public Text PatientName;
    public GameObject BackgroundImage;

	// Use this for initialization
	void Awake () {
        EventManager.UIInit += SetPatientInfo;
        EventManager.UI_Init();

    }
	

    void SetPatientInfo()
    {
        PatientName.text = "Welcome " + AppManager.instance.User.name + "!";
    }

    public void StartMemory()
    {
        System.Random rnd = new System.Random();
        int r = rnd.Next(MemoryManager.instance._memories.Count);
        Memories m = MemoryManager.instance._memories[r];
        MemoryManager.instance._currentmemory = m;
        Debug.Log(MemoryManager.instance._currentmemory.name);
        SceneManager.LoadSceneAsync("Memory");
    }
}
