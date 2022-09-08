using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GoToArrow : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Arrow", 1.0f);
    }
    void Arrow()
    {
        SceneManager.LoadScene("avoidRain3");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
