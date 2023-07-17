using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChangeYS : MonoBehaviour
{
    public Button YButton;
    public Button SButton;

    void Start()
    {
        Button btnMountY = YButton.GetComponent<Button>();
        btnMountY.onClick.AddListener(Yes);
        Button btnMountS = SButton.GetComponent<Button>();
        btnMountS.onClick.AddListener(No);
    }

    void Yes()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(5);
    }

    void No()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(6);
    }

}