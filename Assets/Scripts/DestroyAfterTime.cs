using UnityEngine;
using System.Collections;

public class DestroyAfterTime : MonoBehaviour {

    public float deathTime;

    private float curLifeTime;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (curLifeTime > deathTime)
        {
            Destroy(gameObject);
        }
        else
        {
            curLifeTime += Time.deltaTime;
        }
	}
}
