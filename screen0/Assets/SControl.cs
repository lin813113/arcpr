using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SControl : MonoBehaviour
{
    public void PlayGame()
    {
        //呼叫第一場景
        SceneManager.LoadScene(0);
    }
    public void QuitGame()
    {
        //離開遊戲
        Application.Quit();
    }
}
