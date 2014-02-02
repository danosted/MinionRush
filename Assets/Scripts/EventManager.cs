using UnityEngine;
using System.Collections;

public class EventManager : MonoBehaviour {

    public GameObject spawnPointObject;

    public float enemySpawnTimer = 3.5f;
    public float barrelSpawnTimer = 2f;

    public int levelScaleTime = 25;

    [SerializeField]
    public GameObject[] enemyPrefab;
    public int maxLvl = 2;

    public GameObject barrelPrefab;

    private float curEnemySpawnTimer = 0.0f;
    private float curBarrelSpawnTimer = 0.0f;
    private float nextEnemySpawnTimer = 0.0f;
    private float nextBarrelSpawnTimer = 0.0f;

    private float timeElapsed = 0.0f;

    private Vector3 spawnPoint;
    private int curLvl = 0;
    
    
    

	// Use this for initialization
	void Start () {
        spawnPoint = spawnPointObject.transform.position;
        maxLvl = enemyPrefab.Length-1;
	}
	
	// Update is called once per frame
	void Update () {
        if (curEnemySpawnTimer > nextEnemySpawnTimer)
        {
            //Debug.Log("Spawning enemy!");
            GameObject newEnemy;
            newEnemy = Instantiate(enemyPrefab[curLvl], spawnPoint, Quaternion.identity) as GameObject;
            newEnemy.GetComponent<ObjectStatsScript>().SetStats();
            nextEnemySpawnTimer = enemySpawnTimer + Random.Range(-0.7f, 0.7f);
            curEnemySpawnTimer = 0.0f;
        }
        else
        {
            curEnemySpawnTimer += Time.deltaTime;
        }

        if (curBarrelSpawnTimer > nextBarrelSpawnTimer)
        {
            //Debug.Log("Spawning barrel!");
            GameObject newBarrel;
            newBarrel = Instantiate(barrelPrefab, spawnPoint, Quaternion.identity) as GameObject;
            newBarrel.GetComponent<ObjectStatsScript>().SetStats();
            nextBarrelSpawnTimer = barrelSpawnTimer + Random.Range(-0.4f, 0.4f);
            curBarrelSpawnTimer = 0.0f;
        }
        else
        {
            curBarrelSpawnTimer += Time.deltaTime;
        }

        timeElapsed += Time.deltaTime;
        if (timeElapsed > levelScaleTime)
        {
            if(curLvl < maxLvl)
                curLvl++;
            timeElapsed = 0.0f;
            enemySpawnTimer *= 0.8f;
            barrelSpawnTimer *= 0.8f;
        }

	}
}
