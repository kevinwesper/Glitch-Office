using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HallwayMover : MonoBehaviour
{
    public Vector3 teleportPoint;
    public Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if (transform.position.z < 8)
        {
            rb.MovePosition(transform.position + transform.forward * Time.deltaTime);
        }
        if (transform.position.x < 8 && transform.position.z > 8)
        {
            rb.MovePosition(transform.position + transform.right * Time.deltaTime);
        }
        if (transform.position.x > 8 && transform.position.z > 8)
        {
            rb.MovePosition(transform.position + transform.forward * Time.deltaTime);
        }
    }
}
