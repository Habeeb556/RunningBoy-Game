using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coding : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody2D reg;
    int speed = 30;
    int jump = 20;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        reg = GetComponent<Rigidbody2D>();
        int x = 0, y = 0;
        if (Input.GetKey("right"))
        {
            x = speed;
        }
        else if (Input.GetKey("left"))
        {
            x = -speed;
        }
        else if (Input.GetKey("up"))
        {
            y = jump;
        }
        else if (Input.GetKey("down"))
        {
            y = -jump;
        }
        reg.AddForce(new Vector2(x,y));
    }
}
