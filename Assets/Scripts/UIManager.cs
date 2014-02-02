using UnityEngine;
using System.Collections;

public class UIManager : MonoBehaviour {

    private int gooCount;
    private int goldCount;
    private int minionCount;

    [SerializeField]
    private TextMesh gooText;
    [SerializeField]
    private TextMesh goldText;
    [SerializeField]
    private TextMesh minionText;

    [SerializeField]
    private TextMesh[] upgradeTexts;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnGUI()
    {
        /*// Make a background box
        GUI.Box(new Rect(10, 10, 100, 90), "Goo Bank");
        GUI.Box(new Rect(120, 10, 100, 90), "Gold Pile");
        GUI.Box(new Rect(230, 10, 100, 90), "Gold Pile");
        
        GUI.Label(new Rect(10, 30, 80, 60), ""+ gooCount);
        GUI.Label(new Rect(120, 30, 80, 60), "" + goldCount);
        GUI.Label(new Rect(230, 30, 80, 60), "" + minionCount);
         * */
    }

    public void updateGold(int g)
    {
        goldText.text = "Gold Pile: " + g;
    }

    public void updateGoo(int g)
    {
        gooText.text = "Goo Bank: " + g;
    }

    public void updateMinioncount(int c)
    {
        minionText.text = "Minion Count: " + c;
    }

    public void updateUpgrades(int id, int u)
    {
        //Debug.Log("Updating text for upgrade nr. " + id);
        upgradeTexts[id].text = "" + u;
    }
}
