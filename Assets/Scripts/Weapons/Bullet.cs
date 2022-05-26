using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float speed;
    public int damage;

    public void Setup(int damage)
    {
        this.damage = damage;
        GetComponent<Rigidbody>().velocity = transform.forward * speed;
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Zombiee"))  
        {
            // Destroy the thing tagged enemy, not youself
            Destroy(other.gameObject);

            // Could still destroy the bullet itself as well
            Destroy (gameObject);
        }

        if(other != null)
        {
            Destroy(gameObject);
        } 
    }
}
