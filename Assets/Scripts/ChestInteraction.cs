using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestInteraction : MonoBehaviour
{
    public Animator animator;
    private bool isOpened = false;
    public GameObject rewardItem;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && !isOpened)
        {
            OpenChest();
        }
    }

    private void OpenChest()
    {
        isOpened = true;
        animator.SetTrigger("Open");
        Instantiate(rewardItem, transform.position, Quaternion.identity);
    }
}