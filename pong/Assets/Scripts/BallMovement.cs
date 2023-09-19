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
            transform.position = new Vector2(transform.position.x + xSpeed, transform.position.y); // goes right
        }
        else // if xMove is false
        {
            transform.position = new Vector2(transform.position.x - xSpeed, transform.position.y); // goes left
        }
        if (yMove == true)
        {
            transform.position = new Vector2(transform.position.x, transform.position.y + ySpeed); // goes up
        }
        else // if yMove is false
        {
            transform.position = new Vector2(transform.position.x, transform.position.y - ySpeed); // goes down
        }

        if (transform.position.x >= xBorder) // if past the right border
        {
            xMove = false; // goes left
            playerOneScore++; // score goes up by 1
        }
        if (transform.position.x <= -xBorder) // if past the left border
        {
            xMove = true; // goes right
            playerTwoScore++; // score goes up by 1
        }

        scoreTextP1.text = playerOneScore.ToString(); // shows the score
        scoreTextP2.text = playerTwoScore.ToString();   // shows the score
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
