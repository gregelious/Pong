using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallMovement : MonoBehaviour
{
    public float xSpeed = 0; //horizontal speed
    public float ySpeed = 0; // vertical speed
    private float xBorder = 8.5f; // left & right border
    private float yBorder = 4.5f; // up and down border

    public bool xMove = true; // true = right, false = left
    public bool yMove = true; // true = up, false = right

    int playerOneScore; // tracks score
    public Text scoreTextP1; // shows score
    int playerTwoScore; // tracks score
    public Text scoreTextP2; // shows score

    // Start is called before the first frame update
    void Start()
    {
        xSpeed = 0.0125f; // moves to the right
        ySpeed = 0.02f; // moves up
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x >= xBorder) { xMove = false; } // if it goes too far right, goes left
        if (transform.position.x <= -xBorder) { xMove = true; } // if it goes too far left, goes right
        if (transform.position.y >= yBorder) { yMove = false; } // if it goes too far up, goes down
        if (transform.position.y <= -yBorder) { yMove = true; }// if it goes too far down, goes up

        if (xMove == true)
        {
            transform.position = new Vector2(transform.position.x + xSpeed, transform.position.y);
        }
        else
        {
            transform.position = new Vector2(transform.position.x - xSpeed, transform.position.y);
        }
        if (yMove == true)
        {
            transform.position = new Vector2(transform.position.x, transform.position.y + ySpeed);
        }
        else
        {
            transform.position = new Vector2(transform.position.x, transform.position.y - ySpeed);
        }

        if (transform.position.x >= xBorder)
        {
            xMove = false;
            playerOneScore++;
        }
        if (transform.position.x <= -xBorder)
        {
            xMove = true;
            playerTwoScore++;
        }

        scoreTextP1.text = playerOneScore.ToString();
        scoreTextP2.text = playerTwoScore.ToString();   
    }


    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("hit");
        if (collision.collider.CompareTag("Player"))
        {
            if (xMove == true)
            {
                xMove = false;
            }
            else
            {
                xMove = true;
            }
        }
    }
}
