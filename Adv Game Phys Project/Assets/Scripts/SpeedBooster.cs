using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBooster : MonoBehaviour
{
    private float Speed = 0;
    public float maxSpeed = 10;
    public float booster = 10;

    void Update()
    {
        
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Speed = Speed + booster * Time.deltaTime;
    }
}
