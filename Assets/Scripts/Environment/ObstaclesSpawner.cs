using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaclesSpawner : MonoBehaviour
{
    public List<GameObject> obstacles;
    public List<Transform> spawnPoints = new List<Transform>();
    // Start is called before the first frame update
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

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnCoroutine(spawnTime));
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator SpawnCoroutine(int timeForSpawn)
    {
        System.Random randomIndex = new System.Random();

        while (true) {

            int index = randomIndex.Next(0, spawnPoints.Count);
            Vector3 spawnPosition = spawnPoints[index].position;
            int obstaclesIndex = randomIndex.Next(0, obstacles.Count);
            GameObject enemyPrefab = obstacles[index];
            GameObject instantiatedEnemy = Instantiate(enemyPrefab, spawnPosition, enemyPrefab.transform.rotation);

            intantiatedEnemies.Add(instantiatedEnemy);
            enemyCount++;

            if(enemyCount >= maxEnemyCount)
            {
                yield break;
            }
            
            yield return new WaitForSecondsRealtime(timeForSpawn);

        }

    }
}
