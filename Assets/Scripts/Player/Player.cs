using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public HealthBar healthBar;
    public Health health;

    void Start()
    {
        health.currentHealth = health.maxHealth;
        healthBar.SetMaxHealth(100/*health.maxHealth*/);
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            health.TakeDamage(20);
        //healthBar.SetHealth(health.currentHealth);
    }
}
