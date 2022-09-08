using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Yarn.Unity; // yarn namespace

public class conversation : MonoBehaviour
{
    public GameObject characterImg; // ĳ���� �̹��� ���� ���ӿ�����Ʈ
    public Sprite robot;
    public Sprite soldier;
    public Sprite mainSoldier;
    public Sprite ch;

    [YarnCommand("ch")]
    public void Ch()
    {
        characterImg.GetComponent<Image>().sprite = ch;
    }

    [YarnCommand("robot")]
    public void Robot()
    {
        characterImg.GetComponent<Image>().sprite = robot;
    }

    [YarnCommand("soldier")]
    public void miniR()
    {
        characterImg.GetComponent<Image>().sprite = soldier;
    }

    [YarnCommand("mainSoldier")]
    public void MainSoldier()
    {
        characterImg.GetComponent<Image>().sprite = mainSoldier;
    }
}
