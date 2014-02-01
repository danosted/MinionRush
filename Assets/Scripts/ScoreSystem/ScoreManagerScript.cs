using UnityEngine;
using System.Collections;

public class ScoreManagerScript : MonoBehaviour {

	[SerializeField]
	private int gold;
	[SerializeField]
	private int goo;
    [SerializeField]
	private UIManager UIManager;
	
	private int highscore;
	private int minionCount;

    void Start()
    {
        UIManager.updateGold(this.gold);
        UIManager.updateGoo(this.goo);
        UIManager.updateMinioncount(this.minionCount);
    }

	public void AddGold(int gold)
	{
		this.gold += gold;
        UIManager.updateGold(this.gold);
	}

	public bool RemoveGold(int gold)
	{
		if(this.gold-gold >= 0)
		{
			this.gold -= gold;
            UIManager.updateGold(this.gold);
			return true;
		}
		else
		{
			return false;
		}
	}

	public void AddGoo(int goo)
	{
		this.goo += goo;
        UIManager.updateGoo(this.goo);
	}
	
	public bool RemoveGoo(int goo)
	{
		if(this.goo-goo >= 0)
		{
			this.goo -= goo;
            UIManager.updateGoo(this.goo);
			return true;
		}
		else
		{
			return false;
		}
	}

	public void AddMinion(int minions)
	{
		this.minionCount += minions;
        UIManager.updateMinioncount(this.minionCount);
	}
}
