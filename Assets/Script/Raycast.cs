using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour
{
    public GameObject bullets;
    public Transform spawnToGun;

    public float timeToSpawn;
    private float currentTimeToSpawn;

    void Update()
    {
        RaycastHit hit;
        

        if (currentTimeToSpawn > 0)
        {
            currentTimeToSpawn -= Time.deltaTime;
        }
        else if (Physics.Raycast(transform.position, transform.forward, out hit, 10) && currentTimeToSpawn <= 0)
        {
            BulletsFiring();
            currentTimeToSpawn = timeToSpawn;
        }

    }

    public void BulletsFiring()
    {
            var bullet = Instantiate(bullets, spawnToGun.position, spawnToGun.rotation);     
    }
    
}
