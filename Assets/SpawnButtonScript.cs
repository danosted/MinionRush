using UnityEngine;
using System.Collections;

public class SpawnButtonScript : MonoBehaviour {

	[SerializeField]
	private GameObject minionSelectPopup;
	[SerializeField]
	private int id;

	public delegate void OnMinionSelectDelegate(int id);
	public event OnMinionSelectDelegate OnMinionSelect;

	private Clickable clickable;
	private bool isShowingPopup;

	void Start()
	{
		clickable = GetComponent<Clickable>();
		clickable.OnPress += ShowMinionSelectPopUp;
		clickable.OnClick += ShowMinionSelectPopUp;
		isShowingPopup = false;

	}

	//TODO:
	private void ShowMinionSelectPopUp()
	{
		if(OnMinionSelect != null)
			OnMinionSelect(id);
		//isShowingPopup = true;
	}

	private void HideMinionSelectPopUp()
	{

	}

	private void SelectMinion(int id)
	{
		OnMinionSelect(id);
	}

}
