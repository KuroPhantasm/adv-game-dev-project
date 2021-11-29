using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Movement : MonoBehaviour
{
    private Rigidbody rb;
    private int count;
    public float speed = 10f;
    public bool cubeGrounded = true;
    public TextMeshProUGUI countText;
    public GameObject winTextObject;
    public GameObject loseTextObject;
    

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        SetCountText();
        winTextObject.SetActive(false);
        loseTextObject.SetActive(false);
    }

    void Update()
    {
        if(Input.GetButtonDown("Jump") && cubeGrounded)
        {
            rb.AddForce(new Vector3(0, 10, 0), ForceMode.Impulse);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "points")
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            SetCountText();
        }

        if (other.gameObject.tag == "gg")
        {
            loseTextObject.SetActive(true);
        }
    }

    void SetCountText()
    {
        countText.text = "Score: " + count.ToString();

        if (count >= 8)
        {
            winTextObject.SetActive(true);
        }
    }
}
