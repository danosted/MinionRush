using UnityEngine;
using System.Collections;

public class MovementController : MonoBehaviour {

    

    private float movespeed;
    private int moveDirection;

    private CreatureScript creatureScript;
    private CharacterController charController;

    private var collisionFlags : CollisionFlags;

	// Use this for initialization
	void Start () {
        creatureScript = transform.GetComponent<CreatureScript>();
        movespeed = creatureScript.movespeed;
        moveDirection = creatureScript.moveDirection;
        charController = transform.GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
        Move(movespeed);
	    
	}

    void Move(float speed) {
        var movement = moveDirection * speed;
        movement *= Time.deltaTime;
        collisionFlags = CharacterController.Move(new Vector3(0, movement,0));
    }
}
