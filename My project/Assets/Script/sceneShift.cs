using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Yarn.Unity;

public class sceneShift : MonoBehaviour
{
    public GameObject Canvas;

    [YarnCommand("intro1")]
    public void ScIntoro1()
    {
        SceneManager.LoadScene("Intro 1");
    }

    [YarnCommand("intro2")]
    public void ScIntoro2()
    {
        SceneManager.LoadScene("Intro 2");
    }

    [YarnCommand("intro3")]
    public void ScIntoro3()
    {
        SceneManager.LoadScene("Intro 3");
    }

    [YarnCommand("1Story")]
    public void Sc1Story()
    {
        SceneManager.LoadScene("1Story");
    }

    [YarnCommand("1Story1")]
    public void Sc1Story1()
    {
        SceneManager.LoadScene("1Story 1");
    }

    [YarnCommand("1Story2")]
    public void Sc1Stor21()
    {
        SceneManager.LoadScene("1Story 2");
    }

    [YarnCommand("1Story3")]
    public void Sc1Story3()
    {
        SceneManager.LoadScene("1Story 3");
    }
}