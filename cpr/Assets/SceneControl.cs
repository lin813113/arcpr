using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneControl : MonoBehaviour
{
    public void PlayGame()
    {
        //�I�s�Ĥ@����
        SceneManager.LoadScene(1);
    }
    public void QuitGame()
    {
        //���}�о�
        Application.Quit();
    }
}
