using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public bool canMove = true;

    void Start()
    {
        UIController.OnPlayerWin += TurnOffMovement;  // adding this method to the Action
    }
    void Update()
    {
        if (canMove)
        {
            transform.position += 6 * Time.deltaTime * new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0).normalized;
        }
    }

    public void TurnOffMovement()
    {
        canMove = false;
    }
}
