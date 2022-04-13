using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public float maxHealth = 100;
    public float Tabloons = 0;
    
    public float currentHealth; 
    public HealthBar healthBar;
    
    public bool immuned;
    public float immunityCooldown;
    public float startimmunityCooldown;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
        immunityCooldown = startimmunityCooldown;
    }

    // Update is called once per frame
    void Update()
    {
        if (immuned && immunityCooldown >= 0)
        {
            ImmunityCooldown();
        }
        else
        {
            immuned = false;
            immunityCooldown = startimmunityCooldown;
        }
    }
    void ImmunityCooldown()
    {
        immunityCooldown -= Time.deltaTime;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy") && !immuned)
        {
            TakeDamage(5);
            immuned = true;
        }
    }
    
    void TakeDamage(float damage)
    {
        currentHealth -= damage;

        healthBar.SetHealth(currentHealth);
    }
}



