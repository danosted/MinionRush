using UnityEngine;
using System.Collections;

public class MinionSpawnerScript : MonoBehaviour {

	[SerializeField]
	private float gooAmount;
	[SerializeField]
	private float poopForce;
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
			buttons[i].GetComponent<SpawnButtonScript>().OnMinionSelect += SpawnMinion;
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
