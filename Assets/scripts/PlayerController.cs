using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private int speed = 20;
    public float horizontal;
    public float vertical;
    public Rigidbody rb;
    public int force = 10;
    
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * speed * vertical);
        transform.Rotate(Vector3.up * Time.deltaTime * speed * horizontal);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * force, ForceMode.Impulse);
        }
    }
}
