using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class person : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void active(GameObject a){
        a.SetActive(true);
    }
    public void deactive(GameObject a){
        a.SetActive(false);
    }
}
