using UnityEngine;
using System.Collections;

public class AnimationController : MonoBehaviour {

    public GameObject mesh;

    private Animator animator;

	// Use this for initialization
	void Start () {
        animator = mesh.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
	    
	}

    public void StartAnim(string anim)
    {
         
    }
}
