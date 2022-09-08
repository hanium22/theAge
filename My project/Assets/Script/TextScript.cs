using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class TextScript : MonoBehaviour
{
    public Text UserText;

    // Start is called before the first frame update
    void Start()
    {
        UserText.text = Web.realusername;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
