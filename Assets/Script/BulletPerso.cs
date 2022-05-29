using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletPerso : MonoBehaviour
{
    public float speed = 10f;
    public Rigidbody rb;
    public float life = 3;


    void Start()
    {
        rb.velocity = transform.forward * -speed;
    }

    void Awake()
    {
        Destroy(gameObject, life);
    }
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);

        if (collision.gameObject.TryGetComponent<HPEnemy>(out HPEnemy enemyComponent))
        {
            enemyComponent.TakeDamage(1);
        }

        Destroy(gameObject);
    }
}
