using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Trap : MonoBehaviour
{
    public UnityEvent trapTrigger;  // this is our trap event which we can assign methods to IN EDITOR

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            trapTrigger.Invoke();  // we invoke the event here
        }
    }
}
