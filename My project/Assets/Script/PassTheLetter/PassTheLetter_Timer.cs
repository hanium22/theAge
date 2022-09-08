using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PassTheLetter_Timer : MonoBehaviour
{
    public float limitTime = 10;
    public TextMeshProUGUI textTimer;
    public GameObject TruePopup;
    int Min;
    float Sec;

    void Update()
    {
        limitTime -= Time.deltaTime;

        if (limitTime >= 60f)
        {
            Min = (int)limitTime / 60;
            Sec = limitTime % 60;
            textTimer.text = Min + " : " + (int)Sec;
            
        }
        if (limitTime < 60f)
        {
            textTimer.text = "<color=blue>" + (int)limitTime + "</color>";
        }

        if (limitTime <= 0)
        {
           
                limitTime = 10;
     
        }
        else if (TruePopup.activeSelf == true) {
            // SceneManager.LoadScene("");
        }


    }
}