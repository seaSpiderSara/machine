using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_script : MonoBehaviour
{

    public Transform target;
    public float smoothSpeed = 0.125f;
    public Vector3 offset;

    private Vector3 _velocity = Vector3.zero;
    private ball _ball;


    
    private void Start()
    {
        if(target == null)
        {
            target = GameObject.FindGameObjectWithTag("ball").transform;
            _ball = target.GetComponent<ball>();
        }
    }

  
    private void LateUpdate()
    {
        Transform currentTarget = target;

        Vector3 desiredPosition = currentTarget.position + offset;

        Vector3 smoothedPosition = Vector3.SmoothDamp(transform.position, desiredPosition, ref _velocity, smoothSpeed);
        transform.position = smoothedPosition;
    }
}
