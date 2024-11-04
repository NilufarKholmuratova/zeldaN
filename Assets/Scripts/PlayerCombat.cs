using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCombat : MonoBehaviour
{
    public int maxHealth = 3;
    public int currentHealth;
    public Transform attackPoint;
    public float attackRange = 0.5f;
    public LayerMask enemyLayers;
    public int attackDamage = 1;

    private void Start()
    {
        currentHealth = maxHealth;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Attack();
        }
    }

    private void Attack()
    {
        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers);
        foreach (Collider2D enemy in hitEnemies)
        {
            enemy.GetComponent<EnemyAI>().TakeDamage(attackDamage);
        }
    }

    private void OnDrawGizmosSelected()
    {
        if (attackPoint == null) return;
        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        if (currentHealth <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        // Game over logic
        Debug.Log("Player Died");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
