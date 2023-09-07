using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float xSpeed = 0;
    public float ySpeed = 0;
    private float xBorder = 8.5f;
    private float yBorder = 4.5f;
    // Start is called before the first frame update
    void Start()
    {
        xSpeed = 0.0125f;
        ySpeed = 0.02f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(transform.position.x + xSpeed, transform.position.y + ySpeed);

        if (transform.position.x >= xBorder)
        {
            xSpeed = -xSpeed;
        }
        if (transform.position.x <= -xBorder)
        {
            xSpeed = -xSpeed;
        }
        if (transform.position.y >= yBorder)
        {
            ySpeed = -ySpeed;
        }
        if (transform.position.y <= -yBorder)
        {
            ySpeed = -ySpeed;
        }
    }
}
