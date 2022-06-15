using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class triggerUnityEvent : MonoBehaviour
{
    public UnityEvent OnTrigger;

    //smth with event function

    private void OnTriggerEnter2D(Collider2D col)
    {
        OnTrigger.Invoke();
    }

}
