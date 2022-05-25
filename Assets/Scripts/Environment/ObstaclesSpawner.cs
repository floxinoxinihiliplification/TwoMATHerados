using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaclesSpawner : MonoBehaviour
{
    public List<GameObject> obstacles;
    public GameObject zombie;
    public List<Transform> spawnPoints = new List<Transform>();
    // Start is called before the first frame update
    public PlayerMovement player;
    public List<GameObject> intantiatedEnemies;
    public float spawnTime;
    public int obstaclesSpawnAfterInterations;
    public int maxEnemyCount;
    private int enemyCount;

    private Coroutine spawnCoroutine;

    private void Awake()
    {
        intantiatedEnemies = new List<GameObject>();
    }

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnCoroutine(spawnTime));
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator SpawnCoroutine(float timeForSpawn)
    {
        System.Random randomIndex = new System.Random();
        int obstacleSpawnCounter = 0; //obstacles should spawn when this counter reaches certain number, until then only zombies
        int lastObstacleIndex = 0;
        bool obstacleWasSpawnedInLastInteration = false;
        
        while (true) {

            int index = randomIndex.Next(0, spawnPoints.Count);
            if(obstacleWasSpawnedInLastInteration && index == lastObstacleIndex)
            {
                index = (index + 1) % 4;
                obstacleWasSpawnedInLastInteration = false;
            }

            Vector3 spawnPosition = spawnPoints[index].position;
            GameObject enemyPrefab;

            if(obstacleSpawnCounter == obstaclesSpawnAfterInterations)
            {
                int obstaclesIndex = randomIndex.Next(0, obstacles.Count);
                enemyPrefab = obstacles[obstaclesIndex];
                
                obstacleSpawnCounter = 0;
                obstacleWasSpawnedInLastInteration = true;
                lastObstacleIndex = index;
            }
            else
            {
                enemyPrefab = zombie;
                obstacleSpawnCounter++;
            }

            GameObject instantiatedEnemy = Instantiate(enemyPrefab, spawnPosition, enemyPrefab.transform.rotation);
            intantiatedEnemies.Add(instantiatedEnemy);
            
            yield return new WaitForSecondsRealtime(timeForSpawn);

        }

    }
}
