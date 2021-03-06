using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadAndSidewalkMovement : MonoBehaviour
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
        //Debug.Log("Start");
    }

    private void Move()
    {
        Vector3 changeInPosition = new Vector3(-1f, 0f, 0f);
        Vector3 goToPositon = transform.position + changeInPosition * speed * Time.deltaTime;
        GetComponent<Rigidbody>().MovePosition(goToPositon); 
    }

    private void OnTriggerEnter(Collider other)
    {
        //For the love of god rewrite this part please!!!!
        if (other.tag == "LeftBorder" && istriggered == false)
        {
            istriggered = true;
            float goToPositonOnX = -1f * speed * Time.deltaTime;
            Vector3 changeInPosition = new Vector3(transform.localPosition.x + 96f + goToPositonOnX, transform.localPosition.y, transform.localPosition.z);
            transform.localPosition = changeInPosition;
        }
     
    }

    void OnTriggerExit(Collider other)
    {
        istriggered  = false;
    }
}
