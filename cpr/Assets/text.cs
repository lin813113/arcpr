using System.Collections;

using System.Collections.Generic;

using UnityEngine;

using UnityEngine.UI; //�ϥ�Unity UI�{���w�C (Text�OUI���@�����@! �n�ϥδN�����n�[�A���M�|�X�{���~!)



public class text : MonoBehaviour
{

    public Text mytext;

    void Start()
    {

        InvokeRepeating("showHide", 0.5f, 0.5f);

        //0.5���A�C0.5���ƩI�sshowHide�禡�C

        //InokeRepeating ���ƩI�s(���禡�W���A�Ĥ@�����j�X��I�s�A�C�X��I�s�@��)�C

    }

    void showHide()
    {

        if (mytext.text == "")
        { //�p�G mytext���e�O�Ū�

            mytext.text = "���ť����~��"; //�N mytext���e����

        }
        else
        { //�_�h

            mytext.text = ""; //�N mytext���e�令�Ū�

        }

    }

}