using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorInteraction : MonoBehaviour
{
    public Animator animator;
    public bool isOpen = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            ToggleDoor();
        }
    }

    public void ToggleDoor()
    {
        isOpen = !isOpen;
        animator.SetBool("IsOpen", isOpen);
    }
}