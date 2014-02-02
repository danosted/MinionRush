using UnityEngine;
using System.Collections;

public class MinionScript : ObjectStatsScript {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void SetStats(float health = 0.0f, float dam = 0.0f, float movespeed = 0.0f)
    {
        this.health += health;
        this.damage += dam;
        this.movespeed += movespeed;
        transform.GetComponent<FightController>().Initialize();
    }
}
