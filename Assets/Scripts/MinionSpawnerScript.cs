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
	private GameObject minionType1;
	[SerializeField]
	private GameObject minionType2;
	[SerializeField]
	private GameObject minionType3;
	[SerializeField]
	private GameObject button1;
	[SerializeField]
	private GameObject button2;
	[SerializeField]
	private GameObject button3;

	private Clickable clickable;
	
	void Start () {
	
		clickable = button1.GetComponent<Clickable>();
		clickable.OnClick += SpawnMinion1;
		clickable = button2.GetComponent<Clickable>();
		clickable.OnClick += SpawnMinion2;
		clickable = button3.GetComponent<Clickable>();
		clickable.OnClick += SpawnMinion3;

	}

	private void SpawnMinion1()
	{
		GameObject minionGO;
		minionGO = Instantiate(minionType1, button1.transform.position, minionType1.transform.rotation) as GameObject;
		minionGO.transform.parent = pool;
		minionGO.rigidbody2D.AddForce(Vector3.right * poopForce);
	}

	private void SpawnMinion2()
	{
		GameObject minionGO;
		minionGO = Instantiate(minionType2, button2.transform.position, minionType2.transform.rotation) as GameObject;
		minionGO.transform.parent = pool;
		minionGO.rigidbody2D.AddForce(Vector3.right * poopForce);
	}

	private void SpawnMinion3()
	{
		GameObject minionGO;
		minionGO = Instantiate(minionType3, button3.transform.position, minionType3.transform.rotation) as GameObject;
		minionGO.transform.parent = pool;
		minionGO.rigidbody2D.AddForce(Vector3.right * poopForce);
	}

}
