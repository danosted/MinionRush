using UnityEngine;
using System.Collections;

public class HealthbarScript : MonoBehaviour {

	[SerializeField]
	private GameObject greenPart;

	private float maxHealth;
	private float currentHealth;
	private Material myMaterial;

	void Start () {

			maxHealth = transform.parent.GetComponent<ObjectStatsScript>().health;
			currentHealth = maxHealth;
			myMaterial = greenPart.renderer.material;
	
	}

	public void DamageTaken(float damage)
	{
		currentHealth = (currentHealth-damage >= 0) ? currentHealth-damage : 0f;
		float cutOffValue = (maxHealth-currentHealth)/maxHealth;
		myMaterial.SetFloat("_Cutoff", cutOffValue);
	}

}
