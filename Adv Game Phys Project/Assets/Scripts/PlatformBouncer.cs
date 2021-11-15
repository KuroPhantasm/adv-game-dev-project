using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformBouncer : MonoBehaviour
{
    [Range(100, 1000)]
    public float bounceHeight;
    

    private void OnTriggerEnter(Collider other)
    {
        GameObject bouncer = other.gameObject;
        Rigidbody rb = bouncer.GetComponent<Rigidbody>();
        rb.AddForce(Vector3.up * bounceHeight);
    }
}
