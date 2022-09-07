using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Player : MonoBehaviour
{
    string dir;
    public void Press_up()
    {
        dir = "up";
    }
    public void Press_down()
    {
        dir = "down";
    }
    public void Press_left()
    {
        dir = "left";
    }
    public void Press_right()
    {
        dir = "right";
    }
    public void Press_nomal()
    {
        dir = "null";
    }
    void OnTriggerEnter2D(Collider2D collider)
    {
        Destroy(collider.gameObject);
        Debug.Log("GAME OVER");
        Handheld.Vibrate();
        //���߿� �������
        Invoke("changeScene", 0.5f);
    }
    void changeScene()
    {
        if (GameController.sec > 10)
            SceneManager.LoadScene("1Story 3");
        else
            SceneManager.LoadScene("avoidRain3");
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 myPos = transform.position;
        //Debug.Log("��ġ:" + transform.position);
        if (dir == "up" && (myPos.y<=34))
        {
            transform.Translate(Vector3.up*0.2f);
        }
        else if (dir == "left" && (myPos.x >= -96))
        {
            transform.Translate(Vector3.left * 0.2f);
        }
        else if (dir == "down" && (myPos.y >= -32))
        {
            transform.Translate(Vector3.down * 0.2f);
        }
        else if (dir=="right" && (myPos.x <= 96))
        {
            transform.Translate(Vector3.right * 0.2f);
        }
    }
}
