using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SawController : MonoBehaviour
{
    public float movementSpeed;
    public float distanceMove;
    private float originalY;
    private bool upOrDown;

    private void Start()
    {
        originalY = transform.position.y;
        upOrDown = true;
    }
    private void Update()
    {
        moveSaw();
    }

    public void moveSaw()
    {
        if (upOrDown)
        {
            transform.Translate(Vector2.down * movementSpeed * Time.deltaTime);
            if (transform.position.y <= originalY - distanceMove)
            {
                upOrDown = !upOrDown;
            }
        }
        else
        {
            transform.Translate(Vector2.up * movementSpeed * Time.deltaTime);
            if (transform.position.y >= originalY)
            {
                upOrDown = !upOrDown;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            Debug.Log("Dead");
        }
    }
}
