using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UIManager : MonoBehaviour {
    public Text PatientName;
	// Use this for initialization
	void Awake () {
        EventManager.UIInit += SetPatientInfo;
        EventManager.UI_Init();
	}
	
    void SetPatientInfo()
    {
        PatientName.text = "Welcome " + AppManager.instance.User.name + "!";
    }
}
