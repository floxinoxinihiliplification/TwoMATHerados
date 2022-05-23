using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingSpawner : MonoBehaviour
{
    public List<GameObject> buildings;
    public Transform spawnPosition;
    public PlayerMovement player;
    public List<GameObject> intantiatedEnemies;
    public int spawnTime;
    public int maxEnemyCount;
    private int enemyCount;

    private Coroutine spawnCoroutine;

    private void Awake()
    {
        intantiatedEnemies = new List<GameObject>();
    }

    void Start()
    {
        StartCoroutine(SpawnCoroutine(spawnTime));  
    }

    public IEnumerator SpawnCoroutine(int timeForSpawn)
    {
        System.Random randomIndex = new System.Random();

        while (true) {

            int index = randomIndex.Next(0, buildings.Count);
            GameObject buildingPrefab = buildings[index];
            GameObject instantiatedEnemy = Instantiate(buildingPrefab, spawnPosition.position, buildingPrefab.transform.rotation);

            intantiatedEnemies.Add(instantiatedEnemy);
            enemyCount++;

            if(enemyCount >= maxEnemyCount)
            {
                //yield break;
            }
            
            yield return new WaitForSecondsRealtime(timeForSpawn);

        }

    }
}
