using UnityEngine;
using System.Collections;

public class ObjectStatsScript : MonoBehaviour {

    public float health = 1;
    public float movespeed = 1;
    public float damage = 1;
    public float range = 1;
    public float attackCooldown = 1;
    public int goo = 0;
    public int gold = 0;

    public int moveDirection = 1;

    public GameObject deathFX;
	public GameObject pickup;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    // NO CHANGE VALUES OF THIS SCRIPT (during runtime). HANDS OFF

    public void Die()
    {
		if(deathFX)
        	Instantiate(deathFX, transform.position, Quaternion.identity);
		if(pickup)
		{
			GameObject PickupScriptGO = Instantiate(pickup, transform.position, Quaternion.identity) as GameObject;
			PickupScriptGO.GetComponent<PickupScript>().SetDropValues(goo, gold);
		}
        Destroy(gameObject);
    }

    public void SetStats(float health = 0.0f, float dam = 0.0f, float movespeed = 0.0f)
    {
        //Debug.Log("Setting stats!");
        this.health += health;
        this.damage += dam;
        this.movespeed += movespeed;
        transform.GetComponent<FightController>().Init();
    }
}
