using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fadeAway : MonoBehaviour
{
    GameObject panelObj;               //판넬오브젝트
    Image panelImg;                            //판넬 이미지

    void Awake()
    {
        panelObj = this.gameObject;                         //스크립트 참조된 오브젝트
        panelImg = panelObj.GetComponent<Image>();    //판넬오브젝트에 이미지 참조
    }

    void Update()
    {
        if (panelObj.activeSelf == true)
        {
            StartCoroutine("crossIconSplash"); //코루틴
        }
    }

    IEnumerator crossIconSplash()
    {

        Color color = panelImg.color;                            //color 에 판넬 이미지 참조

        for (int i = 100; i >= 0; i--)                            //for문 100번 반복 0보다 작을 때 까지
        {
            color.a -= Time.deltaTime * 0.01f;               //이미지 알파 값을 타임 델타 값 * 0.01
            panelImg.color = color;                                //판넬 이미지 컬러에 바뀐 알파값 참조

            if (panelImg.color.a <= 0)                        //만약 판넬 이미지 알파 값이 0보다 작으면
            {
                panelObj.SetActive(false);
                color.a = 255;
                
                Debug.Log("SetActive false");
            }
        }
        yield return null;  //코루틴 종료
        Update();
    }
    
}
