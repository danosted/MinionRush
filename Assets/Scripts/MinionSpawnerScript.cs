using UnityEngine;
using System.Collections;

public class MinionSpawnerScript : MonoBehaviour {

	[SerializeField]
	private float poopForce;
	[SerializeField]
	private ScoreManagerScript scoreManager;
	[SerializeField]
	private Transform pool;
	[SerializeField]
	private GameObject[] minions;
	[SerializeField]
	private GameObject[] buttons;
	[SerializeField]
	private GameObject[] spawnpoints;


	void Start () {
	
		for(int i = 0; i < buttons.Length; i++)
		{
			buttons[i].GetComponent<SpawnButtonScript>().OnMinionSelect += CheckMinionSpawn;
		}

	}

	private void CheckMinionSpawn(int id)
	{
		if(scoreManager.RemoveGoo(minions[id].GetComponent<CreatureScript>().goo))
		{
			SpawnMinion(id);
		}
	}

	private void SpawnMinion(int id)
	{
		GameObject minionGO;
		minionGO = Instantiate(minions[id], spawnpoints[id].transform.position, minions[id].transform.rotation) as GameObject;
		minionGO.transform.parent = pool;
		minionGO.rigidbody2D.AddForce(Vector3.right * poopForce);
	}

}
