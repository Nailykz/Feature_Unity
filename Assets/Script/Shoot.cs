using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject bullets;
    public Transform spawnToGun;

    public float timeToSpawn;
    private float currentTimeToSpawn;

    void Update()
    {
        if (currentTimeToSpawn > 0)
        {
            currentTimeToSpawn -= Time.deltaTime;
        }
        else if (Input.GetKeyDown(KeyCode.Space) && currentTimeToSpawn <= 0)
        {
            Shooting();
            currentTimeToSpawn = timeToSpawn;

        }
    }

    public void Shooting()
    {
        var bullet = Instantiate(bullets, spawnToGun.position, spawnToGun.rotation);
    }
}
