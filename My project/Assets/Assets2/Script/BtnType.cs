using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class BtnType : MonoBehaviour
{
    public BTNType currentType;
    public void OnBtnClick()
    {
        switch (currentType)
        {
            case BTNType.Home:
                Debug.Log("Ȩ���� �̵�");
                break;
            case BTNType.GoMiniGame:
                Debug.Log("�̴ϰ����ϱ�");
                SceneManager.LoadScene("ChooseMiniGame");
                break;
            case BTNType.GoAR:
                Debug.Log("���趰����");
                break;

        }
    }
}

