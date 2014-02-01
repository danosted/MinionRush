using UnityEngine;
using System.Collections;

public class MovementController : MonoBehaviour {

    

    private float movespeed;
    private int moveDirection;
    private float verticalSpeed = 0;
    private float gravity = 20;

    private CreatureScript creatureScript;
    private CharacterController charController;
    private EnemyAnimationController animController;

    private bool shouldMove = true;

	// Use this for initialization
	void Start () {
        creatureScript = transform.GetComponent<CreatureScript>();
        movespeed = creatureScript.movespeed;
        moveDirection = creatureScript.moveDirection;
        charController = transform.GetComponent<CharacterController>();
        animController = transform.GetComponent<EnemyAnimationController>();
	}
	
	// Update is called once per frame
	void Update () {
        if (shouldMove)
        {
            //Debug.Log(gameObject + "is moving");
            Move(movespeed);
        }
	    
	}

    void Move(float speed) {
        var movement = moveDirection * speed;
        movement *= Time.deltaTime;
        transform.position += new Vector3(movement, 0, 0);
        //collisionFlags = CharacterController.Move(new Vector3(0, movement,0));
    }

    public void SetMoving(bool s)
    {
       //new WaitForSeconds(Random.Range(0.1f, 0.5f));
        shouldMove = s;
    }
}
