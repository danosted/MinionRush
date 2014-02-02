using UnityEngine;
using System.Collections;

public class UpgradeButtonScript : MonoBehaviour {

    [SerializeField]
    private GameObject minionSelectPopup;
    [SerializeField]
    private int id;
    [SerializeField]
    private MinionSpawnerScript spawnerScript;

    [SerializeField]
    private ScoreManagerScript scoreScript;

    public delegate void OnMinionSelectDelegate(int id);
    public event OnMinionSelectDelegate OnMinionSelect;

    private Clickable clickable;
    private bool isShowingPopup;
    [SerializeField]
    private int[] upgradesCost;

    private int upgLvl = 0;
    

    void Start()
    {
        clickable = GetComponent<Clickable>();
        clickable.OnClick += UpgradeShit;
        isShowingPopup = false;

    }

    void UpgradeShit()
    {
        if(scoreScript.RemoveGold(upgradesCost[upgLvl]))
        {
            //Debug.Log("Calling for upgrade on " + id);
            upgLvl++;
            spawnerScript.Upgrade(id);
        }
    }
}
