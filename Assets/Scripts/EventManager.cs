using UnityEngine;
using System.Collections;

public class EventManager : MonoBehaviour {

    public GameObject spawnPointObject;

    public float enemySpawnTimer = 4.0f;
    public float barrelSpawnTimer = 5.0f;

    public GameObject enemyPrefab;

    public GameObject barrelPrefab;

    private float curEnemySpawnTimer = 0.0f;
    private float curBarrelSpawnTimer = 0.0f;
    private float nextEnemySpawnTimer = 0.0f;
    private float nextBarrelSpawnTimer = 0.0f;

    private Vector3 spawnPoint;

	// Use this for initialization
	void Start () {
        spawnPoint = spawnPointObject.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        if (curEnemySpawnTimer > nextEnemySpawnTimer)
        {
            Debug.Log("Spawning enemy!");
            Instantiate(enemyPrefab, spawnPoint, Quaternion.identity);
            nextEnemySpawnTimer = enemySpawnTimer + Random.Range(-1.0f, 1.0f);
            curEnemySpawnTimer = 0.0f;
        }
        else
        {
            curEnemySpawnTimer += Time.deltaTime;
        }

        if (curBarrelSpawnTimer > nextBarrelSpawnTimer)
        {
            Debug.Log("Spawning barrel!");
            Instantiate(barrelPrefab, spawnPoint, Quaternion.identity);
            nextBarrelSpawnTimer = barrelSpawnTimer + Random.Range(-1.0f, 1.0f);
            curBarrelSpawnTimer = 0.0f;
        }
        else
        {
            curBarrelSpawnTimer += Time.deltaTime;
        }

	}
}
