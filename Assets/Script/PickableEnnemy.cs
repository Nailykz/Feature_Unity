using UnityEngine;
using System.Collections;

public class PickableEnnemy : MonoBehaviour
{
    public Transform player;
    public Transform SpawnPosition;

    private bool hasPlayer = false;
    private bool beingCarried = false;
    private bool touched = false;

    void Update()
    {
        float dist = Vector3.Distance(gameObject.transform.position, player.position);

        if (dist <= 0.5f)
        {
            hasPlayer = true;
        }
        else
        {
            hasPlayer = false;
        }
        if (hasPlayer && Input.GetKey(KeyCode.X))
        {
            GetComponent<Rigidbody>().isKinematic = true;
            transform.parent = SpawnPosition;
            beingCarried = true;
        }

        if (beingCarried)
        {           
            if (touched)
            {
                GetComponent<Rigidbody>().isKinematic = false;
                transform.parent = null;
                beingCarried = false;
                touched = false;
            }
            else if (Input.GetKey(KeyCode.F))
            {
                GetComponent<Rigidbody>().isKinematic = false;
                transform.parent = null;
                beingCarried = false;
            }
        }
    }

    void OnTriggerEnter()
    {
        if (beingCarried)
        {
            touched = true;
        }
    }
}

