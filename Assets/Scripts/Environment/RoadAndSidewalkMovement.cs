using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadAndSidewalkMovement : MonoBehaviour
{
   [SerializeField, Range(1f, 5f)] private float speed = 5f;

    private float vertical;

    private void Update()
    {
        Debug.Log("Update");
        Move();
        //transform.position = new Vector3(5000,500,2000) ;
    }

    void FixedUpdate()
    {
        Debug.Log("FixedUpdate");
        //Move();
    }

    private void Start()
    {
        Debug.Log("Start");
        //transform.position = new Vector3(5000,500,2000) ;
    }

    private void Move()
    {
        Vector3 changeInPosition = new Vector3(-1f, 0f, 0f);
        Vector3 goToPositon = transform.position + changeInPosition * speed * Time.deltaTime;
        GetComponent<Rigidbody>().MovePosition(goToPositon);
    }
}
