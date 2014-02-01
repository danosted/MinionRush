using UnityEngine;
using System.Collections;

public class PickupScript : MonoBehaviour {

	private int gooToAdd;
	private int goldToAdd;

	//TODO: Inject
	[SerializeField]
	private ScoreManagerScript scoreManager;

	void Start()
	{
		gooToAdd = GetComponent<ObjectStatsScript>().goo;
        goldToAdd = GetComponent<ObjectStatsScript>().gold;
	}

	void OnTriggerEnter2D()
	{
		scoreManager.AddGoo(gooToAdd);
		scoreManager.AddGold(goldToAdd);
		Destroy(gameObject);
	}

}
