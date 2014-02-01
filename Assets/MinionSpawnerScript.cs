using UnityEngine;
using System.Collections;

public class MinionSpawnerScript : MonoBehaviour {

	[SerializeField]
	private GameObject minionType1;
	[SerializeField]
	private float gooAmount;

	private Clickable clickable;
	
	void Start () {
	
		clickable = transform.FindChild("Button").GetComponent<Clickable>();
		clickable.OnClick += SpawnMinion;

	}

	private void SpawnMinion()
	{

	}

}
