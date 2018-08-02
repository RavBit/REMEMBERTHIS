using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
public class GameManager : MonoBehaviour {
    public VideoPlayer[] VideoPlayers;

    private void Start()
    {
        DivideVideos();
    }
    void DivideVideos()
    {
        int _currentmemory = Random.Range(0, 2);
        Debug.Log("CURRENTMEMORY " + _currentmemory);
        for (int i = 0; i < VideoPlayers.Length; i++)
        {
            if(i == _currentmemory)
            {
                VideoPlayers[i].url = MemoryManager.instance._currentmemory.video;
            }
            else
            {
                int r = Random.Range(0, MemoryManager.instance._memories.Count);
                VideoPlayers[i].url = MemoryManager.instance._memories[r].video;
            }
        }
        for (int i = 0; i < VideoPlayers.Length; i++)
        {
            VideoPlayers[i].Play();
        }
    }
}
