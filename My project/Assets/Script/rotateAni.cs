using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateAni : MonoBehaviour
{
    public int _rotSpeed = 10;

    void Update()
    {

        transform.Rotate(0, 0, _rotSpeed * Time.deltaTime);
    }

    void resetAnim()
    {
        transform.rotation = Quaternion.identity;
    }
}
