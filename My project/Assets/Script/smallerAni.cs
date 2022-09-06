using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class smallerAni : MonoBehaviour
{
    float time;
    
    void Update()
    {
        transform.localScale = Vector3.one * (2 - time); //2변경 시 지속시간 바뀜

        if (time > 2f) //2변경 시 지속시간 바뀜
        {
            time = 0;
            gameObject.SetActive(false);
        }
        time += Time.deltaTime;
    }

    public void resetAni()
    {
        time = 0;
        transform.localScale = Vector3.one;
    }
}
