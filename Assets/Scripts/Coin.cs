using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Coin : MonoBehaviour
{
    public UnityEvent coinCollect;  // this is our coin event which we can assign methods to IN EDITOR

    void Start()
    {
        // adding listeners so that the prefab spawned will have these methods in its coinCollect event
        // this is because coins are prefabs and prefabs cannot get assigned objects from the scene for the event manually 
        // since they are not "in" the scene at that moment
        coinCollect.AddListener(GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>().IncreaseScore);
        coinCollect.AddListener(GameObject.FindGameObjectWithTag("UIController").GetComponent<UIController>().UpdateScore);
        coinCollect.AddListener(GameObject.FindGameObjectWithTag("UIController").GetComponent<UIController>().CheckWin);
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            coinCollect?.Invoke();  // we invoke the event here (? is for checking if coinCollect is not null)
            Destroy(gameObject);
        }
    }
}
