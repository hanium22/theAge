using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Clear : MonoBehaviour
{
    public Button btn1;
    public Button btn2;
    public Button btn3;
    public Button btn4;
    public Button btn5;

    public int n = 0;

    void Start()
    {
        if (btn1 != null)
        {
            btn1.onClick.AddListener(plusOne);
        }

        if (btn2 != null)
        {
            btn2.onClick.AddListener(plusOne);
        }

        if(btn3 != null)
        {
            btn3.onClick.AddListener(plusOne);
        }

        if(btn4 != null)
        {
            btn4.onClick.AddListener(plusOne);
        }

        if(btn5 != null)
        {
            btn5.onClick.AddListener(plusOne);
        }
    }

    public void plusOne()
    {
        n += 1;
        Debug.Log("n =" + n);

        if (n >= 3)
        {
            Debug.Log("Game Clear");
        }
    }
}
