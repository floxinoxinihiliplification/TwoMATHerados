using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateEnemy : MonoBehaviour
{
    public GameObject Enemy;
    public float xPos;
    public float zPos;
    public int enemyCount;

    void Start()
    {
        StartCoroutine(enemyDrop());
    }

    IEnumerator enemyDrop() {
        /*while(enemyCount < 5)
        {
            xPos = Random.Range(-251, -233);
            zPos = Random.Range(5, 13);

            Instantiate(Enemy, new Vector3(xPos, 70.2f, zPos), Quaternion.identity);

            yield return new WaitForSeconds(2f);

            enemyCount++;
        }*/

        yield return new WaitForSeconds(2f);
    }

}
