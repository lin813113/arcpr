using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class quitgame : MonoBehaviour
{

    public void QuitGame()
    {
        Application.Quit();
        EditorApplication.isPlaying = false;//編輯狀態可以結束遊戲
    }
}
