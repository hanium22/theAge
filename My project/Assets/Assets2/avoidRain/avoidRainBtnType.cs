using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class avoidRainBtnType : MonoBehaviour
{

    public avoidRainBTNType currentType;
    public void OnBtnClick()
    {
        switch (currentType)
        {
            case avoidRainBTNType.start1:
                Debug.Log("����1");
                SceneManager.LoadScene("avoidRain2");
                break;
            case avoidRainBTNType.start2:
                SceneManager.LoadScene("avoidRain3");
                Debug.Log("����2");
                break;
            case avoidRainBTNType.left:
                Debug.Log("����");
                break;
            case avoidRainBTNType.right:
                Debug.Log("������");
                break;
            case avoidRainBTNType.up:
                Debug.Log("��");
                break;
            case avoidRainBTNType.down:
                Debug.Log("�Ʒ�");
                break;

        }
    }
    // Start is called before the first frame update
//    void Start()
 //   {
        
 //   }

    // Update is called once per frame
  //  void Update()
  //  {
        
   // }
}
