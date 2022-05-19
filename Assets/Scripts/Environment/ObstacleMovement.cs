using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    [SerializeField, Range(1f, 50f)] private float speed = 5f;

    private float vertical;
    private bool istriggered = false; 

    private void FixedUpdate()
    {
        Move();
    }

    private void Start()
    {
        
    }

    private void Move()
    {
        Vector3 changeInPosition = new Vector3(-1f, 0f, 0f);
        Vector3 goToPositon = transform.position + changeInPosition * speed * Time.deltaTime;
        GetComponent<Rigidbody>().MovePosition(goToPositon); 
    }
}
