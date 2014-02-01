using UnityEngine;
using System.Collections;

public class ScoreManagerScript : MonoBehaviour {

	[SerializeField]
	private int gold;
	[SerializeField]
	private int goo;
	
	private int highscore;
	private int minionCount;
	
	public void AddGold(int gold)
	{
		this.gold += gold;
	}

	public bool RemoveGold(int gold)
	{
		if(this.gold-gold >= 0)
		{
			this.gold -= gold;
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
	}
	
	public bool RemoveGoo(int goo)
	{
		if(this.goo-goo >= 0)
		{
			this.goo -= goo;
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
	}
}
