using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class quitgame : MonoBehaviour
{

    public void QuitGame()
    {
        Application.Quit();
        EditorApplication.isPlaying = false;//�s�説�A�i�H�����C��
    }
}
