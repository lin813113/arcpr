using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneControl : MonoBehaviour
{
    public void PlayGame()
    {
        //呼叫第一場景
        SceneManager.LoadScene(1);
    }
    public void QuitGame()
    {
        //離開教學
        Application.Quit();
    }
}
