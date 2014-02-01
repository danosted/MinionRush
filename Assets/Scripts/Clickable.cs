using UnityEngine;
using System.Collections;

public class Clickable : MonoBehaviour {
	
	public delegate void OnClickDelegate();
	public event OnClickDelegate OnClick;

	public delegate void OnPressDelegate();
	public event OnPressDelegate OnPress;

	public delegate void OnExitDelegate();
	public event OnExitDelegate OnExit;
	
	void OnMouseUp()
	{
		if(OnClick != null)
			OnClick();
	}

	void OnMouseExit()
	{
		if(OnExit != null)
			OnExit();
	}

	void OnMouseDown()
	{
		if(OnPress != null)
			OnPress();
	}

	void OnMouseEnter()
	{
		if(Input.GetMouseButton(0))
		{
			if(OnPress != null)
				OnPress();
		}
	}
	
}
