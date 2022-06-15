using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camcam : MonoBehaviour
{
    public Transform target;
    private ball _ball;

   
     private void Start()
    {
        target = GameObject.FindGameObjectWithTag("ball").transform;
    }


    void Update()
    {
        
    }
}
