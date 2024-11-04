using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public int health = 3;
    public float speed = 2.0f;
    public Transform player;

    private void Update()
    {
        if (player != null)
        {
            Vector3 direction = (player.position - transform.position).normalized;
            transform.position += direction * speed * Time.deltaTime;
        }
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        Destroy(gameObject);
    }
}