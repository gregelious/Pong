using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle2Movement : MonoBehaviour
{

    public float speed = 1f;
    public float yBorder = 4.5f;
    // Start is called before the first frame update
    void Start()
    {
        speed = .05f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W) && transform.position.y <= yBorder)
        {
            transform.position = new Vector2(transform.position.x, transform.position.y + speed);
        }
        if (Input.GetKey(KeyCode.S) && transform.position.y >= -yBorder)
        {
            transform.position = new Vector2(transform.position.x, transform.position.y - speed);
        }
    }
}
