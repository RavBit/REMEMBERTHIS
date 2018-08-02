﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using DG.Tweening;
public class GameManager : MonoBehaviour {
    public VideoPlayer[] VideoPlayers;
    public MeasuringManager MM;
    public Video_Controller[] VR;
    public GameObject BackgroundImage;

    public GameObject[] PolaroidObject;
    [SerializeField]
    private int _currentmemory;

    [Header("End screen stuff")]
    public GameObject EndResult;
    public Image EndBorder;
    public Text EndText;

    private void Awake()
    {
        EventManager.BackgroundToggle += SetBackGroundBlack;
        EventManager.EndScreen += ShowEndMessage;
    }
    private void Start()
    {
        EndText.gameObject.SetActive(false);
        EndText.DOFade(0, 0.1f);
        EndBorder.gameObject.SetActive(false);
        EndBorder.DOFade(0, 0.1f);
        DivideVideos();
    }
    void DivideVideos()
    {
        _currentmemory = Random.Range(0, 2);
        Debug.Log("CURRENTMEMORY " + _currentmemory);
        for (int i = 0; i < VideoPlayers.Length; i++)
        {
            if(i == _currentmemory)
            {
                VideoPlayers[i].url = MemoryManager.instance._currentmemory.video;
                VR[i].ThumbnailImage.sprite = ContentManager.instance.Thumbnails[MemoryManager.instance._currentmemory.thumbnail];
            }
            else
            {
                int r = Random.Range(0, MemoryManager.instance._memories.Count);
                VideoPlayers[i].url = MemoryManager.instance._memories[r].video;
                VR[i].ThumbnailImage.sprite = ContentManager.instance.Thumbnails[MemoryManager.instance._memories[r].thumbnail];
            }
        }
    }
    void SetBackGroundBlack(bool toggle)
    {
        BackgroundImage.SetActive(toggle);
    }

    void ShowEndMessage()
    {
        EndResult.SetActive(true);
        EndText.gameObject.SetActive(true);
        EndText.DOFade(1, 2);
        EndText.text = MemoryManager.instance._currentmemory.description;
    }

    public void ChooseVideo(int number)
    {
        if(number == _currentmemory)
        {
            VR[_currentmemory].PlayFinishedVideo();
            Debug.Log("RIGHT!!");
            MM.StartCoroutine("UpdateResources");
            EndBorder.gameObject.SetActive(true);
            EndBorder.DOFade(0.7f, 30);
        }
        else
        {
            Destroy(PolaroidObject[number].gameObject);
            Debug.Log("Wrong");
            MemoryManager.instance.tries = MemoryManager.instance.tries + 1;
        }
    }

    public void EndGame()
    {
        Destroy(ContentManager.instance.gameObject);
        Destroy(MemoryManager.instance.gameObject);
        SceneManager.LoadScene("Home");

    }
}