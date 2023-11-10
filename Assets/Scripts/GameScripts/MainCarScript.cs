using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCarScript : MonoBehaviour
{
    public float carVerticalSpeed, carHorizontalSpeed, defaultCarSpeed;
    private float verticalMovement, horizontalMovement;
    Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    void FixedUpdate()
    {
        verticalMovement = Input.GetAxis("Vertical");
        horizontalMovement = Input.GetAxis("Horizontal");
        rb.velocity = new Vector3(horizontalMovement * carHorizontalSpeed * 50 * Time.deltaTime, defaultCarSpeed + carVerticalSpeed * verticalMovement * 50 * Time.deltaTime);

        if (transform.position.x > 1.7f)
        {
            Vector3 rightLimit = new Vector3(1.7f, transform.position.y);
            transform.position = rightLimit;
        } // SAÐ SINIR KONTROL

        if (transform.position.x < -1.7f)
        {
            Vector3 leftLimit = new Vector3(-1.7f, transform.position.y);
            transform.position = leftLimit;
        } // SOL SINIR KONTROL
    }
}
