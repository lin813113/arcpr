using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paneldisapper : MonoBehaviour
{
    public GameObject panel;
    public float delay = 5f;

    void Start()
    {
        StartCoroutine(HideAfterDelay(delay));
    }

    IEnumerator HideAfterDelay(float delay)
    {
        panel.SetActive(true); // 顯示提示框

        yield return new WaitForSeconds(delay);

        panel.SetActive(false); // 隱藏提示框
    }
}
