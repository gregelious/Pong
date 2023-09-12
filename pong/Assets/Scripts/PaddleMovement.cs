using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleMovement : MonoBehaviour
{

    public float speed = 1f;
    public float yBorder = 4.5f;
    // Start is called before the first frame update
    void Start()
    {
        speed = .01f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.O))
        {
            transform.position = new Vector2(transform.position.x, transform.position.y + speed);
        }
    }
}
