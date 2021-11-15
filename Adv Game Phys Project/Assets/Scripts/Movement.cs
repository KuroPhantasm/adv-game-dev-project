using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody rb;
    public float speed = 5f;

    private void Move(float input)
    {
        rb.AddForce(transform.forward * input * speed, ForceMode.Force);
    }
}
