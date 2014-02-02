using UnityEngine;
using System.Collections;

public class SegmentManagerScript : MonoBehaviour {

	[SerializeField]
	private GameObject[] segmentGOs;
	[SerializeField]
	private float speed = 1f;

	private Vector3 leftMarker;
	private Vector3 rightMarker;

	private float width;
	private GameObject[] segments;

	void Start () {

		//Initialize
		segments = new GameObject[3];
		width = segmentGOs[0].transform.FindChild("Ground").localScale.x;
		segments[0] = Instantiate(segmentGOs[0], new Vector3(-width, 0f, 0f), Quaternion.identity) as GameObject;
		segments[1] = Instantiate(segmentGOs[1], transform.position, Quaternion.identity) as GameObject;
		segments[2] = Instantiate(segmentGOs[2], new Vector3(width, 0f, 0f), Quaternion.identity) as GameObject;

		//Start
		StartCoroutine(StartMoving ());

	}

	private IEnumerator StartMoving()
	{
		while(true)
		{
			for(int i = 0; i < segments.Length; i++)
			{
				Vector3 origin = segments[i].transform.position;
				segments[i].transform.position = Vector3.Lerp(origin, origin + Vector3.left * speed, Time.fixedDeltaTime);
				if(segments[i].transform.position.x < -width)
				{
					segments[i].transform.position = new Vector3(width*2, 0f, 0f);
					origin = segments[i].transform.position;
					segments[i].transform.position = Vector3.Lerp(origin, origin + Vector3.left * speed, Time.fixedDeltaTime);
				}
			}
			yield return null;
		}
	}
	
}
