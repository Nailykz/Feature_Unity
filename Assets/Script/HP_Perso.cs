using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HP_Perso : MonoBehaviour
{
    [SerializeField] float health;
    [SerializeField] float maxHealth = 3f;

    private void Start()
    {
        health = maxHealth;
    }

    public void TakeDamagePerso (float damagePerso)
    {
        health -= damagePerso;

        if(health <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}