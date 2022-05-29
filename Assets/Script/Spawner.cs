using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject bullets;

    public GameObject spawnToGun;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(bullets, spawnToGun.transform) ;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
