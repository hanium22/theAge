using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Yarn.Unity;

public class characterShift : MonoBehaviour
{
    public GameObject characterImg;
    public Sprite hero;
    public Sprite happyHero;
    public Sprite perplexedHero;
    public Sprite miniHero;
    public Sprite robot;
    public Sprite miniRobot;
    public Sprite layer;
    public Sprite ceramic;
    public Sprite brokenCeramic;
    public Sprite mainSoldier;
    public Sprite enemy;
    public Sprite enemies;

    [YarnCommand("layer")]
    public void Layer()
    {
        characterImg.GetComponent<Image>().sprite = layer;
    }

    [YarnCommand("hero")]
    public void Hero()
    {
        characterImg.GetComponent<Image>().sprite = hero;
    }

    [YarnCommand("happy")]
    public void happy()
    {
        characterImg.GetComponent<Image>().sprite = happyHero;
    }

    [YarnCommand("perplexed")]
    public void perplexed()
    {
        characterImg.GetComponent<Image>().sprite = perplexedHero;
    }

    [YarnCommand("miniH")]
    public void Mini()
    {
        characterImg.GetComponent<Image>().sprite = miniHero;
    }

    [YarnCommand("robot")]
    public void Robot()
    {
        characterImg.GetComponent<Image>().sprite = robot;
    }

    [YarnCommand("miniR")]
    public void miniR()
    {
        characterImg.GetComponent<Image>().sprite = miniRobot;
    }

    [YarnCommand("ceramic")]
    public void Ceramic()
    {
        characterImg.GetComponent<Image>().sprite = ceramic;
    }

    [YarnCommand("bCeramic")]
    public void bCeramic()
    {
        characterImg.GetComponent<Image>().sprite = brokenCeramic;
    }

    [YarnCommand("mainS")]
    public void MainSoldier()
    {
        characterImg.GetComponent<Image>().sprite = mainSoldier;
    }

    [YarnCommand("mainEnemy")]
    public void Enemy()
    {
        characterImg.GetComponent<Image>().sprite = enemy;
    }


    [YarnCommand("enemies")]
    public void Enemies()
    {
        characterImg.GetComponent<Image>().sprite = enemies;
    }
}
