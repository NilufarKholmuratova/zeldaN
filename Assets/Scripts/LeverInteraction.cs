using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverInteraction : MonoBehaviour
{
    public GameObject linkedDoor;
    public Animator leverAnimator;
    private bool isActivated = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && !isActivated)
        {
            ActivateLever();
        }
    }

    private void ActivateLever()
    {
        isActivated = true;
        leverAnimator.SetTrigger("Activate");
        linkedDoor.GetComponent<DoorInteraction>().ToggleDoor();
    }
}