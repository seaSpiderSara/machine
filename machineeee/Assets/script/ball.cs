using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
     public KeyCode ButtonSpace = KeyCode.Space;
     public Rigidbody2D ball_1;

     void Update()
    {
        if (Input.GetKeyDown(ButtonSpace))
        {
            ball_1.gravityScale += 1;
        }
    }
}
