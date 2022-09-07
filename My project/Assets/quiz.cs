using System.Collections;
using System.Collections.Generic; 
using UnityEngine;

public class quiz : MonoBehaviour
{
    public GameObject wrongPopup;
    public GameObject correctPopup;
    public GameObject GoNext;

    // Start is called before the first frame update
    void Start()
    {
        wrongPopup.SetActive(false);
        correctPopup.SetActive(false);
        GoNext.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void disappear()
    {
        wrongPopup.SetActive(false);
        correctPopup.SetActive(false);
        
    }
    public void pressed_wrong()
    {
        wrongPopup.SetActive(true);
        GoNext.SetActive(true);
        Invoke("disappear", 2f);
    }

    public void pressed_correct()
    {
        correctPopup.SetActive(true);
        GoNext.SetActive(true);
        Invoke("disappear", 2f);
    }

   
}
