using UnityEngine;

public class TiltController : MonoBehaviour
{
    [SerializeField] private float tiltSpeed = 5f;

    // Update is called once per frame
    void Update()
    {
        float horizontal = -Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.forward, horizontal * Time.deltaTime * tiltSpeed);
    }
}
