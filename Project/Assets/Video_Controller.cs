using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using DG.Tweening;
public class Video_Controller : MonoBehaviour {

    public VideoPlayer VP;
    public GameObject GM;
    public Image ThumbnailImage;

    private void Start()
    {
        GM.GetComponent<RawImage>().DOFade(0, 1);
        GM.GetComponent<Transform>().DOScaleY(0, 1);
    }


    public void PlayVideo()
    {
        EventManager.Background_Toggle(true);
        GM.SetActive(true);
        GM.GetComponent<RawImage>().DOFade(1, 1f);
        GM.GetComponent<Transform>().DOScaleY(1, 1);
        VP.Play();
        Invoke("StopVideo", 8);
    }
    public void PlayFinishedVideo()
    {
        EventManager.Background_Toggle(true);
        GameObject.Find("Background_Music").GetComponent<AudioSource>().DOFade(0, 0.75f);
        Invoke("StartFinishedVideo", 0.75f);
    }
    public void StartFinishedVideo()
    {
        GameObject.Find("Background_Music").GetComponent<AudioSource>().Stop();
        GM.SetActive(true);
        GM.GetComponent<RawImage>().DOFade(1, 2f);
        GM.GetComponent<Transform>().DOScaleY(1, 2);
        GameObject.Find("Background_Music").GetComponent<AudioSource>().DOFade(1, 0.75f);
        GameObject.Find("Background_Music").GetComponent<AudioSource>().Play();
        VP.Play();
        Invoke("EndVideo", 16);
    }

    void EndVideo()
    {
        GameObject.Find("Background_Music").GetComponent<AudioSource>().DOFade(0, 0.75f);
        VP.isLooping = true;
        EventManager.End_Screen();
    }

    public void StopVideo()
    {
        GM.GetComponent<RawImage>().DOFade(0, 0.5f);
        GM.GetComponent<Transform>().DOScaleY(0, 0.5F);
        Invoke("CancelVideo", 1);
    }
    
    void CancelVideo()
    {
        VP.Stop();
        EventManager.Background_Toggle(false);
    }
}
