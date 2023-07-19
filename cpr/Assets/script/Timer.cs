using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Timer : MonoBehaviour
{
    public GameObject Cube;
    public GameObject Text;
    public VideoPlayer video;

    void Start()
    {
        Invoke("Disappear", 5f);
    }

    void Disappear()
    {
        Text.SetActive(false);
        Cube.SetActive(true);
        video.Play();
    }

}
