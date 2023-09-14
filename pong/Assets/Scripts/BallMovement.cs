using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallMovement : MonoBehaviour
{
    public float xSpeed = 0;
    public float ySpeed = 0;
    private float xBorder = 8.5f;
    private float yBorder = 4.5f;

    public bool xMove = true;
    public bool yMove = true;

    int playerOneScore;
    public Text scoreTextP1;
    int playerTwoScore;
    public Text scoreTextP2;

    // Start is called before the first frame update
    void Start()
    {
        xSpeed = 0.0125f;
        ySpeed = 0.02f;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x >= xBorder) { xMove = false; }
        if (transform.position.x <= -xBorder) { xMove = true; }
        if (transform.position.y >= yBorder) { yMove = false; }
        if (transform.position.y <= -yBorder) { yMove = true; }

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
