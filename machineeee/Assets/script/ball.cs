using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
     public KeyCode ButtonSpace = KeyCode.Space;
     public Rigidbody2D ball_1;
  //   public gameObject circle_1st;

    //public gameObject FirstBall;

    // Update is called once per frame
     void Update()
    {
        if (Input.GetKeyDown(ButtonSpace))
        {
            ball_1.gravityScale += 1;
        }
    }
}
