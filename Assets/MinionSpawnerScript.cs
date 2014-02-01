using UnityEngine;
using System.Collections;

public class MinionSpawnerScript : MonoBehaviour {

	[SerializeField]
	private GameObject minionType1;
	[SerializeField]
	private GameObject SpawnPosition;
	[SerializeField]
	private float gooAmount;

	private Clickable clickable;
	
	void Start () {
	
		clickable = transform.FindChild("Button").GetComponent<Clickable>();
		clickable.OnClick += SpawnMinion;

	}

	private void SpawnMinion()
	{
		GameObject minionGO;
		minionGO = Instantiate(minionType1, SpawnPosition.transform.position, minionType1.transform.rotation) as GameObject;
		minionGO.rigidbody2D.AddForce(Vector3.right * 100f);
	}

}
