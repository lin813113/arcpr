using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class changescene : MonoBehaviour
{
    public double time;
    public double ctime;
    private bool videoplay = true;
    public VideoPlayer Video;
    public GameObject cube;
    private void Awake()
    {
        time = Video.GetComponent<VideoPlayer>().clip.length;
    }

    // Update is called once per frame
    void Update()
    {
        if(cube.gameObject.activeSelf == true)
        {
            ctime += Time.deltaTime;
            if (ctime >= time)
            {
                videoplay = false;
            }
        }
        
        if (videoplay == false)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(0);
        }
    }
}
