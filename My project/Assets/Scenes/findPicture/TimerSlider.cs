using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;   // Silder class ����ϱ� ���� �߰��մϴ�.
using UnityEngine.SceneManagement;

public class TimerSlider : MonoBehaviour
{
    Slider slTimer;
    float fSliderBarTime;
    void Start()
    {
        slTimer = GetComponent<Slider>();
    }

    void Update()
    {
        if (slTimer.value > 0.0f)
        {
            // �ð��� ������ ��ŭ slider Value ������ �մϴ�.
            slTimer.value -= Time.deltaTime;
        }
        else
        {
            SceneManager.LoadScene("findPicture");
            Debug.Log("Time is Zero.");
        }
    }
}
