using UnityEngine;
using System.Collections;

public class EnemyAnimationController : MonoBehaviour {

    public GameObject mesh;

    public string attackAnimation;

    private Animator animator;

	// Use this for initialization
	void Start () {
        animator = mesh.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update (){
	}

    public void PlayAnimation(string anim)
    {
        mesh.animation.Play(anim);
    }
}
