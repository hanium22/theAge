using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fadeInOut : MonoBehaviour

{

    GameObject panelObj;               //�ǳڿ�����Ʈ
    Image panelImg;                            //�ǳ� �̹���

    private bool checkbool = false;     //���� ���� ���� ����

    void Awake()
    {
        panelObj = this.gameObject;                         //��ũ��Ʈ ������ ������Ʈ
        panelImg = panelObj.GetComponent<Image>();    //�ǳڿ�����Ʈ�� �̹��� ����
    }

    void Update()
    {
        StartCoroutine("MainSplash");                        //�ڷ�ƾ    //�ǳ� ���� ����
        if (checkbool)                                            //���� checkbool �� ���̸�
        {
            Destroy(this.gameObject);                        //�ǳ� �ı�, ����
        }
    }

    IEnumerator MainSplash()
    {
        Color color = panelImg.color;                            //color �� �ǳ� �̹��� ����

        for (int i = 100; i >= 0; i--)                            //for�� 100�� �ݺ� 0���� ���� �� ����
        {
            color.a -= Time.deltaTime * 0.01f;               //�̹��� ���� ���� Ÿ�� ��Ÿ �� * 0.01
            panelImg.color = color;                                //�ǳ� �̹��� �÷��� �ٲ� ���İ� ����

            if (panelImg.color.a <= 0)                        //���� �ǳ� �̹��� ���� ���� 0���� ������
            {
                checkbool = true;                              //checkbool �� 
            }
        }
        yield return null;                                        //�ڷ�ƾ ����
    }
}
