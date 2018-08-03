using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
public class PlayFinalMemory : MonoBehaviour {
    public VideoPlayer VP;
    public GameObject LastVideo;
    public void OpenLastVideo()
    {
        foreach (Memories m in MemoryManager.instance._memories)
        {
            if(m.ID == PlayerPrefs.GetInt("MemoryID"))
            {
                VP.url = m.video;
            }
        }
        LastVideo.SetActive(true);
        VP.Play();
        Invoke("Stop_Video", 30);
    }

    public void Stop_Video()
    {
        LastVideo.SetActive(false);
        VP.Stop();
    }
}
