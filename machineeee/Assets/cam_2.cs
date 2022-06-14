using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cam_2 : MonoBehaviour
{
   public Transform target_2;
   public float smoothSpeed = 0.125f;
   public Vector3 offset;

   private Vector3 _velocity = Vector3.zero;
   
   private ball _ball_2;


    private void Start()
    {
       if (target_2 == null)
       {
            target_2 = GameObject.FindGameObjectWithTag("ball").transform;
          _ball_2 = target_2.GetComponent<ball>();
       }
   }

   private void LateUpdate()
    {
        Transform currentTarget = target_2;

        Vector3 desiredPosition = currentTarget.position + offset;

       Vector3 smoothedPosition = Vector3.SmoothDamp(transform.position, desiredPosition, ref _velocity, smoothSpeed);
        transform.position = smoothedPosition;
    }
}
