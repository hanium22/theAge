using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Joistick : MonoBehaviour
{
    private Vector3 vector;
    public float speed = 0.5F;
    GameObject user;

    void Start()
    {
        user = GameObject.Find("User");
    }

    void Update()
    {
        vector.Set(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), 0);
        if(vector.x!=0 || vector.y != 0)
        {
            transform.Translate(vector.x * speed, vector.y * speed, 0);
        }
    }

    public void LeftMove()
    {
        user.transform.Translate(-1.0f * speed, 0, 0);
    }

    public void RightMove()
    {
        user.transform.Translate(1.0f * speed, 0, 0);
    }

    public void UpMove()
    {
        user.transform.Translate(0, 1.0f * speed, 0);
    }

    public void DownMove()
    {
        user.transform.Translate(0, -1.0f * speed, 0);
    }
}
