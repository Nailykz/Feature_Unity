using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float baseSpeed = 5f;
    public float speed;
    public float rotationSpeed;

    public bool isSprinting = false;
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");


        Vector3 movementDirection = new Vector3(horizontalInput, 0, verticalInput);
        movementDirection.Normalize();

        transform.Translate(movementDirection * speed * Time.deltaTime, Space.World);

        if (movementDirection != Vector3.zero)
        {
            Quaternion toRotation = Quaternion.LookRotation(movementDirection, Vector3.up);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotationSpeed * Time.deltaTime);
        }

        /* Fonctionne pas des masses */
        if (Input.GetKey(KeyCode.E))
        {
            transform.localEulerAngles = new Vector3(0, 0, 30);
        }
        else if(Input.GetKey(KeyCode.A))
        {
            transform.localEulerAngles = new Vector3(0, 0, -30);
        }
        /* Fonctionne pas des masses */

        if (Input.GetKey(KeyCode.LeftShift))
        {
            isSprinting = true;
        }
        else
        {
            isSprinting = false;
        }

        if (isSprinting == true)
        {
            speed = 7.5f;
        }
        else
        {
            speed = baseSpeed;
        }
    }
}