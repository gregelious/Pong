using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleMovement : MonoBehaviour
{

    public float speed = 1f; // speed
    public float yBorder = 4.5f; // border
    // Start is called before the first frame update
    void Start()
    {
        speed = .05f;// resetting speed
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.O) && transform.position.y <= yBorder) // if I press O and its not outside the border
        {
            transform.position = new Vector2(transform.position.x, transform.position.y + speed); // it goes up
        }
        if (Input.GetKey(KeyCode.L) && transform.position.y >= -yBorder) // if I press L and its not outside the border
        {
            transform.position = new Vector2(transform.position.x, transform.position.y - speed); // it goes down
        }
    }
}
