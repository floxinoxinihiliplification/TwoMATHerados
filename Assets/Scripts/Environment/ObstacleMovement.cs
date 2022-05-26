using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    [SerializeField, Range(1f, 50f)] private float speed = 5f;

    private float vertical;
    private bool istriggered = false; 
    private bool obstacleHit = false;

    private void FixedUpdate()
    {
        Move();
    }

    private void Start()
    {
        
    }

    private void Move()
    {
        Vector3 changeInPosition;
        if(!obstacleHit)
        {
            changeInPosition = new Vector3(-1f, 0f, 0f);
        }
        else
        {
            changeInPosition = new Vector3(-1f, 0f, -1f);
        }
        Vector3 goToPositon = transform.position + changeInPosition * speed * Time.deltaTime;
        GetComponent<Rigidbody>().MovePosition(goToPositon); 
    }

    private void OnTriggerEnter(Collider other)
    {
        if(gameObject.tag == "Zombiee")
        {
            if (other.tag == "Obstacle")
            {
                speed = 5;
                obstacleHit = true; 
            }
            else
            {
                obstacleHit = false;
                speed = 7;
            }
        }
    }
}
