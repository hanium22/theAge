using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FindtheCatBtnType : MonoBehaviour
{
    public FindtheCatBTNType currentType;
    public void OnBtnClick()
    {
        switch (currentType)
        {
            case FindtheCatBTNType.start:
                Debug.Log("���� ����");
                SceneManager.LoadScene("FindtheCat2");
                break;
            case FindtheCatBTNType.start1:
                Debug.Log("���� ����");
                SceneManager.LoadScene("FindtheCat3");
                break;
            case FindtheCatBTNType.TreeButton:
                Debug.Log("���� ���� ����̰� �־��!");
                break;
            case FindtheCatBTNType.RoofButton:
                Debug.Log("���� ���� ����̰� �־��!");
                break;
            case FindtheCatBTNType.WallButton:
                Debug.Log("���� ���� ����̰� �־��!");
                break;

        }
    }
}
