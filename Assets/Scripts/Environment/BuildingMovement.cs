using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingMovement : MonoBehaviour

{
    [SerializeField, Range(1f, 50f)] private float speed = 5f;

    private float vertical;
    private bool istriggered = false; 

    private Coroutine spawnCoroutine;
    
    private void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        Vector3 changeInPosition = new Vector3(-1f, 0f, 0f);
        Vector3 goToPositon = transform.position + changeInPosition * speed * Time.deltaTime;
        GetComponent<Rigidbody>().MovePosition(goToPositon); 
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "buildingCollider" && istriggered == false)
        {
            istriggered = true;
            Debug.Log("Building Collider detected");
            Destroy(gameObject);
        }
     
    }

    void OnTriggerExit(Collider other)
    {
        istriggered  = false;
    }
}

