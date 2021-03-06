using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField, Range(1f, 5f)] private float speed = 5f;

    private float vertical;

    [SerializeField] Weapon weapon;

    private void Update()
    {
        GetInput();

        if(Input.GetMouseButton(0))
        {
            if(weapon != null)
            {
                weapon.Shoot();
                Debug.Log("Shot Fired");
            }
        }
    }

    void FixedUpdate()
    {
        Move();
    }

    private void GetInput()
    {
        vertical = Input.GetAxis("Vertical");
    }

    private void Move()
    {
        Vector3 changeInPosition = new Vector3(0f, 0f, vertical);
        Vector3 goToPositon = transform.position + changeInPosition * speed * Time.deltaTime;
        if(goToPositon.z >= 4.5f && goToPositon.z <= 15)
        {
            GetComponent<Rigidbody>().MovePosition(goToPositon);
        }
    }
}
