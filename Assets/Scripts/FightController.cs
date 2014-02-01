using UnityEngine;
using System.Collections;

public class FightController : MonoBehaviour {

    public GameObject attackFX;

    private FightController target;

    private float damage;
    private float attackCd;
    private float health;

    private float curAtkCd;

    private bool fighting = false;

    private MovementController moveController;
    private CreatureScript creatureScript;

	// Use this for initialization
	void Start () {
        moveController = transform.GetComponent<MovementController>();
        creatureScript = transform.GetComponent<CreatureScript>();
        damage = creatureScript.damage;
        attackCd = creatureScript.attackCooldown;
        health = creatureScript.health;
        curAtkCd = attackCd;
	}
	
	// Update is called once per frame
	void Update () {
        if (fighting && target)
        {
            if (curAtkCd > attackCd)
            {
                //got a target an' ready to bash 'em!
                float targetHealth = target.ApplyDamage(damage);
                GameObject.Instantiate(attackFX, target.transform.position, Quaternion.identity);
                curAtkCd = 0;
                if (targetHealth > 0)
                {
                    //keep fighting this guy
                }
                else
                {
                    //he's dead, get the next one!
                    SetFighting(false);
                }
            }
            else
            {
                //got a target, but not ready to bash
                curAtkCd += Time.deltaTime;
            }
        }
        else
        {
            SetFighting(false);
        }
	}

    void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log(gameObject + " hit a collider with name " + col.gameObject);
        if (col.gameObject.tag == "Ground")
        {

        }
        else
        {
            target = col.transform.GetComponent<FightController>();
            moveController.SetMoving(false);
            fighting = true;
        }
    }

    float ApplyDamage(float dam)
    {
        health -= dam;
        if(health > 0) {
            //still alive bitches!
        } else
        {
          //yargh!
            Destroy(gameObject);
            if (creatureScript)
            {
                creatureScript.Die();
            }
        }
        return health;
    }

    public void SetFighting(bool b)
    {
        fighting = b;
        moveController.SetMoving(!b);
        if (b)
        {
            target = null;
        }
    }
}
