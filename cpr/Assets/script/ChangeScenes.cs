using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChangeScenes : MonoBehaviour
{

    public void scene1()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(1);
    }

    public void scene2U()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(2);
    }
    public void scene2D()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    }
    public void scene3Y()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(3);
    }
    public void scene3N()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(4);
    }
    public void scene5()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(5);
    }
    public void scene6Y()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(6);
    }
    public void scene6N()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(7);
    }
    public void scene7()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    }
    public void scene8()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(8);
    }

    public void scene9()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    }
}