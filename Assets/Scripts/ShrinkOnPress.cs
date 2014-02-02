using UnityEngine;
using System.Collections;

public class ShrinkOnPress : MonoBehaviour {

	[SerializeField]
	private float insetPercentage = 0.9f;
	[SerializeField]
	private Transform scaleTarget;

	private Clickable clickable;
	private Vector3 originalScale;


	void Start()
	{
		originalScale = scaleTarget.localScale;
		clickable = GetComponent<Clickable>();
		clickable.OnPress += OnPress;
		clickable.OnExit += OnRelease;
		clickable.OnClick += OnRelease;
	}

	private void OnPress()
	{
		scaleTarget.localScale = originalScale * insetPercentage;
	}

	private void OnRelease()
	{
		scaleTarget.localScale = originalScale;
	}
}
