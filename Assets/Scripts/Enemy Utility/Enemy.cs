using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Enemy : MonoBehaviour
{
    public int maxHealth = 10;
    public int currentHealth;

    public int damageA = 10;

    private void Start()
    {
        currentHealth = maxHealth;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Deal damage to the player
            PlayerHealth playerHealth = other.GetComponent<PlayerHealth>();
            if (playerHealth != null)
            {
                playerHealth.TakeDamage(damageA);
                aud.PlayOneShot(); // plays the "Enemy Hit" sound
            }
        }
    }

    public void TakeDamage(int damage)
    {
        // Reduce enemy health
        currentHealth -= damage;

        // Check if the enemy is killed
        if (currentHealth <= 0)
        {
            KillEnemy();
        }
    }

    private void KillEnemy()
    {
        Destroy(gameObject); // Kills the enemy
    }
}
