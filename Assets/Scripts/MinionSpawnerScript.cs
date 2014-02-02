using UnityEngine;
using System.Collections;

public class MinionSpawnerScript : MonoBehaviour {

	[SerializeField]
	private float poopForce;
	[SerializeField]
	private ScoreManagerScript scoreManager;
	[SerializeField]
	private Transform pool;
	[SerializeField]
	private GameObject[] minions;
	[SerializeField]
	private GameObject[] buttons;
	[SerializeField]
	private GameObject[] spawnpoints;
    private int[] upgrades;

    [SerializeField]
    private UIManager uiMan;

    [SerializeField]
    private float healthPerUpgrade = 2;
    [SerializeField]
    private float damagePerUpgrade = 1;
    [SerializeField]
    private float movespeedPerUpgrade = -0.2f;


	void Start () {
	
		for(int i = 0; i < buttons.Length; i++)
		{
			buttons[i].GetComponent<SpawnButtonScript>().OnMinionSelect += CheckMinionSpawn;
		}

	}

	private void CheckMinionSpawn(int id)
	{
		if(scoreManager.RemoveGoo(minions[id].GetComponent<ObjectStatsScript>().goo))
		{
			SpawnMinion(id);
		}
	}

	private void SpawnMinion(int id)
	{
		GameObject minionGO;
		minionGO = Instantiate(minions[id], spawnpoints[id].transform.position, minions[id].transform.rotation) as GameObject;
        minionGO.GetComponent<MinionScript>().SetStats(upgrades[0]*healthPerUpgrade, upgrades[1]*damagePerUpgrade, upgrades[2]*movespeedPerUpgrade);
        minionGO.transform.parent = pool;
		minionGO.rigidbody2D.AddForce(Vector3.right * poopForce);
	}

    public void Upgrade(int id)
    {
        upgrades[id]++;
        uiMan.updateUpgrades(id, upgrades[id]);
    }
}
