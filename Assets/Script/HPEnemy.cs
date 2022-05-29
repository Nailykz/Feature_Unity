using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HPEnemy : MonoBehaviour
{
    [SerializeField] float health;
    [SerializeField] float maxHealth = 3f;

    private void Start()
    {
        health = maxHealth;
    }

    public void TakeDamage (float damage)
    {
        health -= damage;

        if(health <= 0)
        {
            Destroy(gameObject);
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}