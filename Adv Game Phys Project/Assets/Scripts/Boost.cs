using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boost : MonoBehaviour
{
    public float multiplier = 1.4f;
    
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Pickup(other);
        }
    }

    void Pickup(Collider player)
    {
        Movement stats =  player.GetComponent<Movement>();
        stats.speed *= multiplier;
        Debug.Log("Made Contact");
    }
}
