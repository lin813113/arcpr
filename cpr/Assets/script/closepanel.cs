using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class closepanel : MonoBehaviour
{
    public GameObject Panel;
    public GameObject cube;
    public VideoPlayer video;

    void Start()
    {
        Invoke("Disappear", 3f);
    }

    void Disappear()
    {
        Panel.SetActive(false);
        cube.SetActive(true);
        video.Play();
    }
}
