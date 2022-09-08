using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainDrop : MonoBehaviour
{
    Vector3 targetPos;
    Vector3 myPos;
    Vector3 newPos;
    // Start is called before the first frame update
    void Start()
    {
        targetPos = GameObject.Find("player").transform.position;
        myPos = transform.position;

        newPos = (targetPos - myPos) * 0.002f;

        Destroy(gameObject,30f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + newPos;
    }
}
