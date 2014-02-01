using UnityEngine;
using System.Collections;

public class PickupScript : MonoBehaviour {

	private int gooToAdd;
	private int goldToAdd;
	
	private ScoreManagerScript scoreManager;

	void Start()
	{
		scoreManager = GameObject.FindGameObjectWithTag("ScoreManager").GetComponent<ScoreManagerScript>();
	}

	public void SetDropValues(int goo, int gold)
	{
		gooToAdd = goo;
		goldToAdd = gold;
	}

	void OnTriggerEnter2D()
	{
		scoreManager.AddGoo(gooToAdd);
		scoreManager.AddGold(goldToAdd);
		Destroy(gameObject);
	}

}
