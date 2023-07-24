using System.Collections;

using System.Collections.Generic;

using UnityEngine;

using UnityEngine.UI; //使用Unity UI程式庫。 (Text是UI的一部份哦! 要使用就必須要加，不然會出現錯誤!)



public class text : MonoBehaviour
{

    public Text mytext;

    void Start()
    {

        InvokeRepeating("showHide", 0.5f, 0.5f);

        //0.5秒後，每0.5秒重複呼叫showHide函式。

        //InokeRepeating 重複呼叫(“函式名”，第一次間隔幾秒呼叫，每幾秒呼叫一次)。

    }

    void showHide()
    {

        if (mytext.text == "")
        { //如果 mytext內容是空的

            mytext.text = "按空白鍵繼續"; //將 mytext內容改變

        }
        else
        { //否則

            mytext.text = ""; //將 mytext內容改成空的

        }

    }

}