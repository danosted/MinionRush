using UnityEngine;
using System.Collections;

public class ObstaclemanagerScript : MonoBehaviour {
	
	[SerializeField]
	private GameObject[] spawnPoints;
	[SerializeField]
	private GameObject[] obstacles;
	
	void Start () {
	
	}

	private IEnumerator SpawnObstacles()
	{
		yield return null;
	}
}
